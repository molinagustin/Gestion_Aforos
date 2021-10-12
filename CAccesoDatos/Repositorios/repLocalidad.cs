using CAccesoDatos.Contratos;
using CAccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace CAccesoDatos.Repositorios
{
    public class repLocalidad : repMaestro, IRepositorioLocalidad
    {
        //Campos
        private string ObtenerLocalidades;

        //Constructor
        public repLocalidad()
        {
            ObtenerLocalidades = "select * from localidades";
        }

        //Metodos
        public int Agregar(entLocalidad entidad)
        {
            throw new NotImplementedException();
        }

        public int Editar(entLocalidad entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int idPk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<entLocalidad> ObtenerRegistros()
        {
            var tabla = ExecuteReader(ObtenerLocalidades);
            List<entLocalidad> localidades = new List<entLocalidad>();
            foreach (DataRow fila in tabla.Rows)
            {
                localidades.Add(new entLocalidad { 
                    IdLoc = Convert.ToInt32(fila[0]),
                    Localidad = fila[1].ToString(),
                    CP = fila[2].ToString(),
                    Activo = Convert.ToBoolean(fila[3]),
                    UsuarioCrea = Convert.ToInt32(fila[4]),
                    FechaCrea = Convert.ToDateTime(fila[5]),
                    UsuarioModif = Convert.ToInt32(fila[6]),
                    FechaUltModif = Convert.ToDateTime(fila[7])
                });
            }
            tabla.Dispose();
            return localidades;
        }
    }
}
