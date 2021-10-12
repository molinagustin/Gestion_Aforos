using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CComun.Cache
{
    //La hacemos estatica para que mantenga en todo momento los datos que le asignemos a los campos en memoria, asi lo podemos usar dentro de la aplicacion. Tambien se podria hacer esta clase en la Capa Dominio y funcionaria igual.
    public static class cacUsuario
    {
        public static int IdUsuarioAct { get; set; }
        public static string NombreUs { get; set; }
        public static string Apellido { get; set; }
        public static string Nombre { get; set; }
        public static int Privilegio { get; set; }
        public static int Acceso { get; set; }
        public static bool AfConexElect { get; set; }
        public static bool ConexElect { get; set; }
    }
}
