using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAccesoDatos.Entidades
{
    public class entProfesional
    {
        public int IdProf { get; set; }
        public string CUIL { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Profesion { get; set; }
        public bool Inspector { get; set; }
        public bool Electricista { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public int UsuarioCrea { get; set; }
        public DateTime FechaCrea { get; set; }
        public int UsuarioModif { get; set; }
        public DateTime FechaUltModif { get; set; }
    }
}
