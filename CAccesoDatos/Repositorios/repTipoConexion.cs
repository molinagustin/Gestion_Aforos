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
    public class repTipoConexion : repMaestro, IRepositorioTipoConexion
    {
        private string ObtenerTiposConex;

        public repTipoConexion()
        {
            ObtenerTiposConex = "select * from tipos_conexiones";
        }
        public int Agregar(entTipoConexion entidad)
        {
            throw new NotImplementedException();
        }

        public int Editar(entTipoConexion entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int idPk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<entTipoConexion> ObtenerRegistros()
        {
            var tabla = ExecuteReader(ObtenerTiposConex);
            List<entTipoConexion> tiposConexiones = new List<entTipoConexion>();
            foreach (DataRow fila in tabla.Rows)
            {
                tiposConexiones.Add(new entTipoConexion
                {
                    IdTipoConex = Convert.ToInt32(fila[0]),
                    EstadoObra = Convert.ToInt32(fila[1]),
                    TipoConexion = fila[2].ToString(),
                    Activo = Convert.ToBoolean(fila[3]),
                    UsuarioCrea = Convert.ToInt32(fila[4]),
                    FechaCrea = Convert.ToDateTime(fila[5]),
                    UsuarioModif = Convert.ToInt32(fila[6]),
                    FechaUltModif = Convert.ToDateTime(fila[7])
                });
            }
            tabla.Dispose();
            return tiposConexiones;
        }
    }
}
