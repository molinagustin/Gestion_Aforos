using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAccesoDatos.Entidades;

namespace CAccesoDatos.Contratos
{
    public interface IRepositorioUsuario : IRepositorioGenerico<entUsuario>
    {
        entUsuario ObtenerUsuarioPorId(int id);
        entUsuario ObtenerUsuarioPorNombreUsuario(string nombreUsuario);
        int InsertarNuevoAcceso(bool afConexElect, bool conexElect);
        void EstablecerCacheAccesosUsuario(int idAcceso);
        IEnumerable<entUsuarioPrivilegios> ObtenerPrivilegios();
        IEnumerable<entUsuarioAcceso> ObtenerAccesos();
        DataTable ObtenerUsuariosDGV();
    }
}
