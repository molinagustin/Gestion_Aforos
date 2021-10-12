using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAccesoDatos.Entidades
{
    public class entUsuario
    {
        //En lugar de usar campos y propiedades, directamente lo simplificamos usando propiedades ya que en C# de esta forma, se crea el campo implicitamente, simplificando codigo
        public int IdUsuarioAct { get; set; }
        public string CUIL { get; set; }
        public string NombreUs { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string SaltCont { get; set; }
        public string HashCont { get; set; }
        public int Privilegio { get; set; }
        public int Acceso { get; set; }
        public bool Activo { get; set; }
        public int UsuarioCrea { get; set; }
        public DateTime FechaCrea { get; set; }
        public int UsuarioModif { get; set; }
        public DateTime FechaUltModif { get; set; }
    }
}
