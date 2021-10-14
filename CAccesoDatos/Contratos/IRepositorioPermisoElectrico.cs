using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAccesoDatos.Entidades;

namespace CAccesoDatos.Contratos
{
    public interface IRepositorioPermisoElectrico : IRepositorioGenerico<entPermisoElectrico>
    {
        DataTable DatosPermisosPDF(int numPermiso);
    }
}
