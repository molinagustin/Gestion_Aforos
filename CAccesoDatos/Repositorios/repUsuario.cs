using CAccesoDatos.Contratos;
using CAccesoDatos.Entidades;
using CComun.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CAccesoDatos.Repositorios
{
    public class repUsuario : repMaestro, IRepositorioUsuario
    {
        //Campos (Cadenas con query sql)
        private string ObtenerUsuarios;
        private string ObtenerUsPorId;
        private string ObtenerUsPorNombreUsuario;
        private string InsertarUsuario;
        private string InsertarAcceso;
        private string EditarUsuario;
        private string EliminarUsuario;
        private string ObtenerPriv;
        private string ObtenerIdNuevoAcceso;
        private string ObtenerAccesosUsuario;
        private string ObtenerAcce;
        private string ObtenerUsDGV;

        //Constructor
        public repUsuario()
        {
            ObtenerUsuarios = "select * from usuarios";

            ObtenerUsPorId = "select * from usuarios where IdUsuarioAct = @IdUsuarioAct";
                        
            ObtenerUsPorNombreUsuario = "select * from usuarios where NombreUs = @NombreUs COLLATE Traditional_Spanish_CS_AS";

            InsertarUsuario = "insert into usuarios (CUIL, NombreUs, Apellido, Nombre, SaltCont, HashCont, Privilegio, Acceso, UsuarioCrea, FechaCrea, UsuarioModif) values (@CUIL, @NombreUs, @Apellido, @Nombre, @SaltCont, @HashCont, @Privilegio, @Acceso, @UsuarioCrea, @FechaCrea, @UsuarioModif)";

            InsertarAcceso = "insert into usuarios_accesos(AfConexElect, ConexElect, UsuarioCrea, FechaCrea, UsuarioModif) values (@AfConexElect, @ConexElect, @UsuarioCrea, @FechaCrea, @UsuarioModif)";

            //Falta ver como editar a la misma vez los accesos si fueron modificados o bien crear una query nueva para los accesos
            EditarUsuario = "update usuarios set CUIL=@CUIL, NombreUs=@NombreUs, Apellido=@Apellido, Nombre=@Nombre, SaltCont=@SaltCont, HashCont=@HashCont, Privilegio=@Privilegio, UsuarioModif=@UsuarioModif, FechaUltModif=@FechaUltModif where IdUsuarioAct=@IdUsuarioAct";

            EliminarUsuario = "update usuarios set Activo=@Activo where IdUsuarioAct=@IdUsuarioAct";

            ObtenerPriv = "select * from usuarios_privilegios";

            ObtenerIdNuevoAcceso = "select MAX(IdUsAc) from usuarios_accesos";

            ObtenerAccesosUsuario = "select * from usuarios_accesos where IdUsAc = @IdUsAc";

            ObtenerAcce = "select * from usuarios_accesos";

            ObtenerUsDGV = "select usuarios.CUIL, usuarios.NombreUs, usuarios.Apellido, usuarios.Nombre, usuarios.Activo, usuarios1.NombreUs, usuarios.FechaCrea, usuarios2.NombreUs, usuarios.FechaUltModif from usuarios inner join usuarios as usuarios1 on usuarios.UsuarioCrea = usuarios1.IdUsuarioAct inner join usuarios as usuarios2 on usuarios.UsuarioModif = usuarios2.IdUsuarioAct";
        }

        public int Agregar(entUsuario entidad)
        {
            parametros = new List<SqlParameter>();
            ParametrosUsuario(ref parametros, entidad);
            return ExecuteNonQuery(InsertarUsuario);
        }

        //Falta terminar de ver la edicion por el tema de editar tambien los accesos
        public int Editar(entUsuario entidad)
        {
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdUsuarioAct", entidad.IdUsuarioAct));
            ParametrosUsuario(ref parametros, entidad);
            return ExecuteNonQuery(EditarUsuario);
        }

        public int Eliminar(int idPk)
        {
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Activo", false));
            parametros.Add(new SqlParameter("@IdUsuarioAct", idPk));
            return ExecuteNonQuery(EliminarUsuario);
        }

        public void EstablecerCacheAccesosUsuario(int idAcceso)
        {
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdUsAc", idAcceso));
            var tabla = ExecuteReaderWithParameters(ObtenerAccesosUsuario);
            cacUsuario.AfConexElect = Convert.ToBoolean(tabla.Rows[0].ItemArray.GetValue(1));
            cacUsuario.ConexElect = Convert.ToBoolean(tabla.Rows[0].ItemArray.GetValue(2));
            tabla.Dispose();
        }

        public int InsertarNuevoAcceso(bool afConexElect, bool conexElect)
        {
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@AfConexElect", afConexElect));
            parametros.Add(new SqlParameter("@ConexElect", conexElect));
            parametros.Add(new SqlParameter("@UsuarioCrea", cacUsuario.IdUsuarioAct));
            parametros.Add(new SqlParameter("@FechaCrea", DateTime.Now));
            parametros.Add(new SqlParameter("@UsuarioModif", cacUsuario.IdUsuarioAct));

            ExecuteNonQuery(InsertarAcceso);
            return ExecuteScalar(ObtenerIdNuevoAcceso);
        }

        public entUsuario ObtenerUsuarioPorId(int id)
        {
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdUsuarioAct", id));
            var tabla = ExecuteReaderWithParameters(ObtenerUsPorId);
            entUsuario usuario = PropiedadesUsuario(tabla.Rows[0]);
            tabla.Dispose();
            return usuario;
        }

        public entUsuario ObtenerUsuarioPorNombreUsuario(string nombreUsuario)
        {
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@NombreUs", nombreUsuario));
            var tabla = ExecuteReaderWithParameters(ObtenerUsPorNombreUsuario);
            entUsuario usuario = new entUsuario();
            foreach (DataRow fila in tabla.Rows)
            {
                usuario = PropiedadesUsuario(fila);
            }
            tabla.Dispose();
            return usuario;
        }

        public IEnumerable<entUsuario> ObtenerRegistros()
        {
            var tabla = ExecuteReader(ObtenerUsuarios);
            var listaUsuarios = new List<entUsuario>();
            foreach (DataRow fila in tabla.Rows)
            {
                listaUsuarios.Add(PropiedadesUsuario(fila));
            }
            tabla.Dispose();
            return listaUsuarios;
        }

        public IEnumerable<entUsuarioPrivilegios> ObtenerPrivilegios()
        {
            var tabla = ExecuteReader(ObtenerPriv);
            var listaPrivilegios = new List<entUsuarioPrivilegios>();
            foreach (DataRow fila in tabla.Rows)
            {
                listaPrivilegios.Add(new entUsuarioPrivilegios
                {
                    IdPriv = Convert.ToInt32(fila[0]),
                    Descripcion = fila[1].ToString(),
                    Activo = Convert.ToBoolean(fila[2]),
                    UsuarioCrea = Convert.ToInt32(fila[3]),
                    FechaCrea = Convert.ToDateTime(fila[4]),
                    UsuarioModif = Convert.ToInt32(fila[5]),
                    FechaUltModif = Convert.ToDateTime(fila[6])
                });
            }
            tabla.Dispose();
            return listaPrivilegios;
        }

        public IEnumerable<entUsuarioAcceso> ObtenerAccesos()
        {
            var tabla = ExecuteReader(ObtenerAcce);
            var listaAccesos = new List<entUsuarioAcceso>();
            foreach (DataRow fila in tabla.Rows)
            {
                listaAccesos.Add(new entUsuarioAcceso
                {
                    IdUsAc = Convert.ToInt32(fila[0]),
                    AfConexElect = Convert.ToBoolean(fila[1]),
                    ConexElect = Convert.ToBoolean(fila[2]),
                    UsuarioCrea = Convert.ToInt32(fila[3]),
                    FechaCrea = Convert.ToDateTime(fila[4]),
                    UsuarioModif = Convert.ToInt32(fila[5]),
                    FechaUltModif = Convert.ToDateTime(fila[6])
                });
            }
            tabla.Dispose();
            return listaAccesos;
        }

        public DataTable ObtenerUsuariosDGV()
        {
            return ExecuteReader(ObtenerUsDGV);
        }

        public void ParametrosUsuario(ref List<SqlParameter> parametros, entUsuario usuario)
        {
            parametros.Add(new SqlParameter("@CUIL", usuario.CUIL));
            parametros.Add(new SqlParameter("@NombreUs", usuario.NombreUs));
            parametros.Add(new SqlParameter("@Apellido", usuario.Apellido));
            parametros.Add(new SqlParameter("@Nombre", usuario.Nombre));
            parametros.Add(new SqlParameter("@SaltCont", usuario.SaltCont));
            parametros.Add(new SqlParameter("@HashCont", usuario.HashCont));
            parametros.Add(new SqlParameter("@Privilegio", usuario.Privilegio));
            parametros.Add(new SqlParameter("@Acceso", usuario.Acceso));
            parametros.Add(new SqlParameter("@UsuarioCrea", usuario.UsuarioCrea));
            parametros.Add(new SqlParameter("@FechaCrea", usuario.FechaCrea));
            parametros.Add(new SqlParameter("@UsuarioModif", usuario.UsuarioModif));
            parametros.Add(new SqlParameter("@FechaUltModif", usuario.FechaUltModif));
        }

        public entUsuario PropiedadesUsuario(DataRow fila)
        {
            var nuevoUsuario = new entUsuario();
            nuevoUsuario.IdUsuarioAct = Convert.ToInt32(fila[0]);
            nuevoUsuario.CUIL = fila[1].ToString();
            nuevoUsuario.NombreUs = fila[2].ToString();
            nuevoUsuario.Apellido = fila[3].ToString();
            nuevoUsuario.Nombre = fila[4].ToString();
            nuevoUsuario.SaltCont = fila[5].ToString();
            nuevoUsuario.HashCont = fila[6].ToString();
            nuevoUsuario.Privilegio = Convert.ToInt32(fila[7]);
            nuevoUsuario.Acceso = Convert.ToInt32(fila[8]);
            nuevoUsuario.Activo = Convert.ToBoolean(fila[9]);
            nuevoUsuario.UsuarioCrea = Convert.ToInt32(fila[10]);
            nuevoUsuario.FechaCrea = Convert.ToDateTime(fila[11]);
            nuevoUsuario.UsuarioModif = Convert.ToInt32(fila[12]);
            nuevoUsuario.FechaUltModif = Convert.ToDateTime(fila[13]);
            return nuevoUsuario;
        }        
    }
}
