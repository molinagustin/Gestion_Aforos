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
    public class repTipoObraConexionElectrica : repMaestro, IRepositorioTipoObraConexionElectrica
    {
        private string ObtenerTiposObrasConex;

        public repTipoObraConexionElectrica()
        {
            ObtenerTiposObrasConex = "select * from tipos_obras_declaradas_anexas";
        }

        public int Agregar(entTipoObraConexionElectrica entidad)
        {
            throw new NotImplementedException();
        }

        public int Editar(entTipoObraConexionElectrica entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int idPk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<entTipoObraConexionElectrica> ObtenerRegistros()
        {
            var tabla = ExecuteReader(ObtenerTiposObrasConex);
            var listaTiposObraCon = new List<entTipoObraConexionElectrica>();
            foreach (DataRow fila in tabla.Rows)
            {
                listaTiposObraCon.Add(new entTipoObraConexionElectrica { 
                    IdTipoObAnex = Convert.ToInt32(fila[0]),
                    TipoObra = Convert.ToInt32(fila[1]),
                    TipoObraAnexa = fila[2].ToString(),
                    Activo = Convert.ToBoolean(fila[3]),
                    UsuarioCrea = Convert.ToInt32(fila[4]),
                    FechaCrea = Convert.ToDateTime(fila[5]),
                    UsuarioModif = Convert.ToInt32(fila[6]),
                    FechaUltModif = Convert.ToDateTime(fila[7])
                });
            }
            tabla.Dispose();
            return listaTiposObraCon;
        }
    }
}
