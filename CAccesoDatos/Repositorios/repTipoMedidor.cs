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
    public class repTipoMedidor : repMaestro, IRepositorioTipoMedidor
    {
        private string ObtenerTiposMedid;

        public repTipoMedidor()
        {
            ObtenerTiposMedid = "select * from tipos_medidores";
        }

        public int Agregar(entTipoMedidor entidad)
        {
            throw new NotImplementedException();
        }

        public int Editar(entTipoMedidor entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int idPk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<entTipoMedidor> ObtenerRegistros()
        {
            var tabla = ExecuteReader(ObtenerTiposMedid);
            List<entTipoMedidor> tiposMedidores = new List<entTipoMedidor>();
            foreach (DataRow fila in tabla.Rows)
            {
                tiposMedidores.Add(new entTipoMedidor
                {
                    IdTipoMed = Convert.ToInt32(fila[0]),
                    TipoMedidor = fila[1].ToString(),
                    Activo = Convert.ToBoolean(fila[2]),
                    UsuarioCrea = Convert.ToInt32(fila[3]),
                    FechaCrea = Convert.ToDateTime(fila[4]),
                    UsuarioModif = Convert.ToInt32(fila[5]),
                    FechaUltModif = Convert.ToDateTime(fila[6])
                });
            }
            tabla.Dispose();
            return tiposMedidores;
        }
    }
}
