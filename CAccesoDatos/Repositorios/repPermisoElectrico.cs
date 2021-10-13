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

        public repPermisoElectrico()
        {
            AgregarNuevoPermiso = "insert into per_conex_electricas (Acronimo, Fecha, Expediente, TipoConex, TipoMedid, TipoObraConex, PotenciaHP, Dias, Iniciador, Domicilio, Localidad, Inspector, Observaciones, Comprobante, Importe, UsuarioCrea, FechaCrea, UsuarioModif) values (@Acronimo, @Fecha, @Expediente, @TipoConex, @TipoMedid, @TipoObraConex, @PotenciaHP, @Dias, @Iniciador, @Domicilio, @Localidad, @Inspector, @Observaciones, @Comprobante, @Importe, @UsuarioCrea, @FechaCrea, @UsuarioModif)";

            ObtenerNumPermiso = "select MAX(NumPermiso) from per_conex_electricas where Expediente=@Expediente";
        }

        public int Agregar(entPermisoElectrico entidad)
        {
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Acronimo", entidad.Acronimo));
            parametros.Add(new SqlParameter("@Fecha", entidad.Fecha));
            parametros.Add(new SqlParameter("@Expediente", entidad.Expediente));
            parametros.Add(new SqlParameter("@TipoConex", entidad.TipoConex));
            parametros.Add(new SqlParameter("@TipoMedid", entidad.TipoMedid));
            parametros.Add(new SqlParameter("@TipoObraConex", entidad.TipoObraConex));
            parametros.Add(new SqlParameter("@PotenciaHP", entidad.PotenciaHP));
            parametros.Add(new SqlParameter("@Dias", entidad.Dias));
            parametros.Add(new SqlParameter("@Iniciador", entidad.Iniciador));
            parametros.Add(new SqlParameter("@Domicilio", entidad.Domicilio));
            parametros.Add(new SqlParameter("@Localidad", entidad.Localidad));
            parametros.Add(new SqlParameter("@Inspector", entidad.Inspector));
            parametros.Add(new SqlParameter("@Observaciones", entidad.Observaciones));
            parametros.Add(new SqlParameter("@Comprobante", entidad.Comprobante));
            parametros.Add(new SqlParameter("@Importe", entidad.Importe));
            parametros.Add(new SqlParameter("@UsuarioCrea", entidad.UsuarioCrea));
            parametros.Add(new SqlParameter("@FechaCrea", entidad.FechaCrea));
            parametros.Add(new SqlParameter("@UsuarioModif", entidad.UsuarioModif));
                        
            ExecuteNonQuery(AgregarNuevoPermiso);
            parametros.Add(new SqlParameter("@Expediente", entidad.Expediente));
            return ExecuteScalarWithParameters(ObtenerNumPermiso);
        }

        public int Editar(entPermisoElectrico entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int idPk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<entPermisoElectrico> ObtenerRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
