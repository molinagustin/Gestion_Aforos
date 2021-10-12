using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAccesoDatos.Entidades;

namespace CAccesoDatos.Contratos
{
    public interface IRepositorioTipoConexion : IRepositorioGenerico<entTipoConexion>
    {
        //Sin metodos para agregar, por el momento, solo usar los heredados
    }
}
