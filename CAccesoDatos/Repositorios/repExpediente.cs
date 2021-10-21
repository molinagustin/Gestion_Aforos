using CAccesoDatos.Contratos;
using CAccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CAccesoDatos.Repositorios
{
    public class repExpediente : repMaestro, IRepositorioExpediente
    {
        //Campos
        private string InsertarExpte;
        private string BuscarExpte;
        private string BuscarExptes;
        private string ObtenerIdNuevoExpte;

        //Constructor
        public repExpediente()
        {
            InsertarExpte = "insert into expedientes (Letra, Anio, Numero, Iniciador, Caratula, UsuarioCrea, FechaCrea, UsuarioModif) values (@Letra, @Anio, @Numero, @Iniciador, @Caratula, @UsuarioCrea, @FechaCrea, @UsuarioModif)";

            BuscarExpte = "select * from expedientes where Anio=@Anio and Numero=@Numero";

            BuscarExptes = "select * from expedientes";

            ObtenerIdNuevoExpte = "select MAX(IdExpte) from expedientes where Anio=@Anio and Numero=@Numero"; //Con esos 2 parametros, si se llegaran a cargar 2 expedientes muy rapidamente, nos aseguramos de obtener el correcto
        }


        public int Agregar(entExpediente entidad)
        {
            entExpediente expediente = BuscarExpediente(entidad.Anio, entidad.Numero);
            if (expediente.IdExpte > 0)            
                return expediente.IdExpte;            

            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Letra", entidad.Letra));
            parametros.Add(new SqlParameter("@Anio", entidad.Anio));
            parametros.Add(new SqlParameter("@Numero", entidad.Numero));
            parametros.Add(new SqlParameter("@Iniciador", entidad.Iniciador));
            parametros.Add(new SqlParameter("@Caratula", entidad.Caratula));
            parametros.Add(new SqlParameter("@UsuarioCrea", entidad.UsuarioCrea));
            parametros.Add(new SqlParameter("@FechaCrea", entidad.FechaCrea));
            parametros.Add(new SqlParameter("@UsuarioModif", entidad.UsuarioModif));

            ExecuteNonQuery(InsertarExpte);
            parametros.Add(new SqlParameter("@Anio", entidad.Anio));
            parametros.Add(new SqlParameter("@Numero", entidad.Numero));
            return ExecuteScalarWithParameters(ObtenerIdNuevoExpte);
        }

        public entExpediente BuscarExpediente(string Anio, string Numero)
        {
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Anio", Anio));
            parametros.Add(new SqlParameter("@Numero", Numero));
            var tabla = ExecuteReaderWithParameters(BuscarExpte);
            entExpediente expediente = new entExpediente();
            foreach (DataRow fila in tabla.Rows)
            {
                expediente.IdExpte = Convert.ToInt32(fila[0]);
                expediente.Letra = fila[1].ToString();
                expediente.Anio = fila[2].ToString();
                expediente.Numero = fila[3].ToString();
                expediente.Iniciador = fila[4].ToString();
                expediente.Caratula = fila[5].ToString();
                expediente.Activo = Convert.ToBoolean(fila[6]);
                expediente.UsuarioCrea = Convert.ToInt32(fila[7]);
                expediente.FechaCrea = Convert.ToDateTime(fila[8]);
                expediente.UsuarioModif = Convert.ToInt32(fila[9]);
                expediente.FechaUltModif = Convert.ToDateTime(fila[10]);
            }
            tabla.Dispose();
            return expediente;
        }

        public int Editar(entExpediente entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int idPk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<entExpediente> ObtenerRegistros()
        {
            var tabla = ExecuteReader(BuscarExptes);
            var listaExpts = new List<entExpediente>();
            foreach (DataRow fila in tabla.Rows)
            {
                listaExpts.Add(PropiedadesExptes(fila));
            }
            tabla.Dispose();
            return listaExpts;
        }

        private entExpediente PropiedadesExptes(DataRow fila)
        {
            var nuevoExpte = new entExpediente();
            nuevoExpte.IdExpte = Convert.ToInt32(fila[0]);
            nuevoExpte.Letra = fila[1].ToString();
            nuevoExpte.Anio = fila[2].ToString();
            nuevoExpte.Numero = fila[3].ToString();
            nuevoExpte.Iniciador = fila[4].ToString();
            nuevoExpte.Caratula = fila[5].ToString();
            nuevoExpte.Activo = Convert.ToBoolean(fila[6]);
            nuevoExpte.UsuarioCrea = Convert.ToInt32(fila[7]);
            nuevoExpte.FechaCrea = Convert.ToDateTime(fila[8]);
            nuevoExpte.UsuarioModif = Convert.ToInt32(fila[9]);
            nuevoExpte.FechaUltModif = Convert.ToDateTime(fila[10]);
            return nuevoExpte;
        }
    }
}
