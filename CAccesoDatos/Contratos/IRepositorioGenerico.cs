using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAccesoDatos.Contratos
{
    public interface IRepositorioGenerico<Entity> where Entity:class
    {
        int Agregar(Entity entidad);
        int Editar(Entity entidad);
        int Eliminar(int idPk);
        IEnumerable<Entity> ObtenerRegistros();
    }
}
