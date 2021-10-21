using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAccesoDatos.Contratos;
using CAccesoDatos.Entidades;

namespace CAccesoDatos.Repositorios
{
    public class repAcronimo : repMaestro, IRepositorioAcronimo
    {
        //Campos
        private string ObtenerAcros;

        //Constructor
        public repAcronimo()
        {
            ObtenerAcros = "select * from acronimos";
        }

        public int Agregar(entAcronimo entidad)
        {
            throw new NotImplementedException();
        }

        public int Editar(entAcronimo entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int idPk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<entAcronimo> ObtenerRegistros()
        {
            var tabla = ExecuteReader(ObtenerAcros);
            List<entAcronimo> acronimos = new List<entAcronimo>();
            foreach (DataRow fila in tabla.Rows)
            {
                acronimos.Add(new entAcronimo { 
                    IdAcron = Convert.ToByte(fila[0]),
                    Acronimo = fila[1].ToString(),
                    Descripcion = fila[2].ToString(),
                    Activo = Convert.ToBoolean(fila[3]),
                    UsuarioCrea = Convert.ToInt32(fila[4]),
                    FechaCrea = Convert.ToDateTime(fila[5]),
                    UsuarioModif = Convert.ToInt32(fila[6]),
                    FechaUltModif = Convert.ToDateTime(fila[7])
                });
            }
            tabla.Dispose();
            return acronimos;
        }
    }
}
