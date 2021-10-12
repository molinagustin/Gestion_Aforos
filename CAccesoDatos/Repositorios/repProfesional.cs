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
    public class repProfesional : repMaestro, IRepositorioProfesional
    {
        //Campos
        private string ObtProfInspElect;

        public repProfesional()
        {
            ObtProfInspElect = "select * from profesionales where Inspector=True and Activo=True";
        }

        //Metodos
        public int Agregar(entProfesional entidad)
        {
            throw new NotImplementedException();
        }

        public int Editar(entProfesional entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int idPk)
        {
            throw new NotImplementedException();
        }

        public List<entProfesional> ObtenerProfesionalesInspectoresElectricos()
        {
            var tabla = ExecuteReader(ObtProfInspElect);
            var listaProfesionales = new List<entProfesional>();
            foreach (DataRow fila in tabla.Rows)
            {
                listaProfesionales.Add(new entProfesional {
                    IdProf = Convert.ToInt32(fila[0]),
                    CUIL = fila[1].ToString(),
                    Apellido = fila[2].ToString(),
                    Nombre = fila[3].ToString(),
                    Profesion = Convert.ToInt32(fila[4]),
                    Inspector = Convert.ToBoolean(fila[5]),
                    Electricista = Convert.ToBoolean(fila[6]),
                    Email = fila[7].ToString(),
                    Telefono = fila[8].ToString(),
                    Activo = Convert.ToBoolean(fila[9]),
                    UsuarioCrea = Convert.ToInt32(fila[10]),
                    FechaCrea = Convert.ToDateTime(fila[11]),
                    UsuarioModif = Convert.ToInt32(fila[12]),
                    FechaUltModif = Convert.ToDateTime(fila[13])
                });
            }

            tabla.Dispose();
            return listaProfesionales;
        }

        public IEnumerable<entProfesional> ObtenerRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
