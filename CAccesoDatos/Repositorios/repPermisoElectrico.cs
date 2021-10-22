using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CAccesoDatos.Contratos;
using CAccesoDatos.Entidades;
using CComun.Cache;

namespace CAccesoDatos.Repositorios
{
    public class repPermisoElectrico : repMaestro, IRepositorioPermisoElectrico
    {
        private string AgregarNuevoPermiso;
        private string ObtenerNumPermiso;
        private string ObtenerDatosPermiso;
        private string ObtenerPermisosEntregados;
        private string ObtenerPermisos;
        private string ActualizarPermiso;

        public repPermisoElectrico()
        {
            AgregarNuevoPermiso = "insert into per_conex_electricas (Acronimo, Fecha, Expediente, TipoConex, TipoMedid, TipoObraConex, PotenciaHP, Dias, Iniciador, Domicilio, Localidad, Inspector, Observaciones, Comprobante, Importe, UsuarioCrea, FechaCrea, UsuarioModif) values (@Acronimo, @Fecha, @Expediente, @TipoConex, @TipoMedid, @TipoObraConex, @PotenciaHP, @Dias, @Iniciador, @Domicilio, @Localidad, @Inspector, @Observaciones, @Comprobante, @Importe, @UsuarioCrea, @FechaCrea, @UsuarioModif)";

            ObtenerNumPermiso = "select MAX(NumPermiso) from per_conex_electricas where Expediente=@Expediente";

            ObtenerDatosPermiso = "select per_conex_electricas.NumPermiso, acronimos.Acronimo, per_conex_electricas.Fecha, expedientes.Anio, expedientes.Numero, expedientes.Letra, tipos_conexiones.TipoConexion, tipos_medidores.TipoMedidor, tipos_obras_declaradas_anexas.TipoObraAnexa, per_conex_electricas.PotenciaHP, per_conex_electricas.Dias, per_conex_electricas.Iniciador, per_conex_electricas.Domicilio, localidades.Localidad, profesionales.Apellido, profesionales.Nombre, profesionales_profesiones.Titulo, per_conex_electricas.Observaciones from per_conex_electricas inner join acronimos on per_conex_electricas.Acronimo = acronimos.IdAcron inner join expedientes on per_conex_electricas.Expediente = expedientes.IdExpte inner join tipos_conexiones on per_conex_electricas.TipoConex = tipos_conexiones.IdTipoConex inner join tipos_medidores on per_conex_electricas.TipoMedid = tipos_medidores.IdTipoMed inner join tipos_obras_declaradas_anexas on per_conex_electricas.TipoObraConex = tipos_obras_declaradas_anexas.IdTipoObAnex inner join localidades on per_conex_electricas.Localidad = localidades.IdLoc inner join profesionales on per_conex_electricas.Inspector = profesionales.IdProf inner join profesionales_profesiones on profesionales.Profesion = profesionales_profesiones.IdProfesion where per_conex_electricas.NumPermiso = @NumPermiso";

            ObtenerPermisosEntregados = "select per_conex_electricas.NumPermiso, per_conex_electricas.Fecha, usuarios1.NombreUs, per_conex_electricas.FechaCrea, usuarios2.NombreUs, per_conex_electricas.FechaUltModif from per_conex_electricas inner join usuarios as usuarios1 on per_conex_electricas.UsuarioCrea = usuarios1.IdUsuarioAct inner join usuarios as usuarios2 on per_conex_electricas.UsuarioModif = usuarios2.IdUsuarioAct";

            ObtenerPermisos = "select * from per_conex_electricas";

            ActualizarPermiso = "update per_conex_electricas set Acronimo=@Acronimo, Fecha=@Fecha, Expediente=@Expediente, TipoConex=@TipoConex, TipoMedid=@TipoMedid, TipoObraConex=@TipoObraConex, PotenciaHP=@PotenciaHP, Dias=@Dias, Iniciador=@Iniciador, Domicilio=@Domicilio, Localidad=@Localidad, Inspector=@Inspector, Observaciones=@Observaciones, Comprobante=@Comprobante, Importe=@Importe, UsuarioCrea=@UsuarioCrea, FechaCrea=@FechaCrea, UsuarioModif=@UsuarioModif, FechaUltModif=@FechaUltModif where NumPermiso=@NumPermiso";
        }

        public int Agregar(entPermisoElectrico entidad)
        {
            parametros = new List<SqlParameter>();
            ParametrosPerElect(ref parametros, entidad);
                        
            ExecuteNonQuery(AgregarNuevoPermiso);
            parametros.Add(new SqlParameter("@Expediente", entidad.Expediente));
            return ExecuteScalarWithParameters(ObtenerNumPermiso);
        }

        public int Editar(entPermisoElectrico entidad)
        {
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@NumPermiso", entidad.NumPermiso));
            ParametrosPerElect(ref parametros, entidad);

            return ExecuteNonQuery(ActualizarPermiso);
        }

        public int Eliminar(int idPk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<entPermisoElectrico> ObtenerRegistros()
        {
            var tabla = ExecuteReader(ObtenerPermisos);
            var listaPermisos = new List<entPermisoElectrico>();
            foreach (DataRow fila in tabla.Rows)
            {
                listaPermisos.Add(new entPermisoElectrico { 
                    NumPermiso = Convert.ToInt32(fila[0]),
                    Acronimo = Convert.ToByte(fila[1]),
                    Fecha = Convert.ToDateTime(fila[2]),
                    Expediente = Convert.ToInt32(fila[3]),
                    TipoConex = Convert.ToInt32(fila[4]),
                    TipoMedid = Convert.ToInt32(fila[5]),
                    TipoObraConex = Convert.ToInt32(fila[6]),
                    PotenciaHP = Convert.ToDecimal(fila[7]),
                    Dias = fila[8].ToString(),
                    Iniciador = fila[9].ToString(),
                    Domicilio = fila[10].ToString(),
                    Localidad = Convert.ToInt32(fila[11]),
                    Inspector = Convert.ToInt32(fila[12]),
                    Observaciones = fila[13].ToString(),
                    Comprobante = fila[14].ToString(),
                    Importe = Convert.ToDecimal(fila[15]),
                    UsuarioCrea = Convert.ToInt32(fila[16]),
                    FechaCrea = Convert.ToDateTime(fila[17]),
                    UsuarioModif = Convert.ToInt32(fila[18]),
                    FechaUltModif = Convert.ToDateTime(fila[19])
                });
            }
            tabla.Dispose();
            return listaPermisos;
        }

        public DataTable DatosPermisosPDF(int numPermiso)
        {
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@NumPermiso", numPermiso));
            return ExecuteReaderWithParameters(ObtenerDatosPermiso);
        }

        public DataTable PermisosGenerados()
        {
            return ExecuteReader(ObtenerPermisosEntregados);
        }

        private void ParametrosPerElect(ref List<SqlParameter> parametros, entPermisoElectrico permiso)
        {
            parametros.Add(new SqlParameter("@Acronimo", permiso.Acronimo));
            parametros.Add(new SqlParameter("@Fecha", permiso.Fecha));
            parametros.Add(new SqlParameter("@Expediente", permiso.Expediente));
            parametros.Add(new SqlParameter("@TipoConex", permiso.TipoConex));
            parametros.Add(new SqlParameter("@TipoMedid", permiso.TipoMedid));
            parametros.Add(new SqlParameter("@TipoObraConex", permiso.TipoObraConex));
            parametros.Add(new SqlParameter("@PotenciaHP", permiso.PotenciaHP));
            parametros.Add(new SqlParameter("@Dias", permiso.Dias));
            parametros.Add(new SqlParameter("@Iniciador", permiso.Iniciador));
            parametros.Add(new SqlParameter("@Domicilio", permiso.Domicilio));
            parametros.Add(new SqlParameter("@Localidad", permiso.Localidad));
            parametros.Add(new SqlParameter("@Inspector", permiso.Inspector));
            parametros.Add(new SqlParameter("@Observaciones", permiso.Observaciones));
            parametros.Add(new SqlParameter("@Comprobante", permiso.Comprobante));
            parametros.Add(new SqlParameter("@Importe", permiso.Importe));
            parametros.Add(new SqlParameter("@UsuarioCrea", permiso.UsuarioCrea));
            parametros.Add(new SqlParameter("@FechaCrea", permiso.FechaCrea));
            parametros.Add(new SqlParameter("@UsuarioModif", permiso.UsuarioModif));
            parametros.Add(new SqlParameter("@FechaUltModif", permiso.FechaUltModif));
        }
    }
}
