using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAccesoDatos.Entidades
{
    public class entExpediente
    {
        public int IdExpte { get; set; }
        public string Letra { get; set; }
        public string Anio { get; set; }
        public string Numero { get; set; }
        public string Iniciador { get; set; }
        public string Caratula { get; set; }
        public bool Activo { get; set; }
        public int UsuarioCrea { get; set; }
        public DateTime FechaCrea { get; set; }
        public int UsuarioModif { get; set; }
        public DateTime FechaUltModif { get; set; }
    }
}
