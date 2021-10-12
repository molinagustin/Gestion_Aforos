using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAccesoDatos.Entidades
{
    public class entPermisoElectrico
    {
        public int NumPermiso { get; set; }
        public byte Acronimo { get; set; } //byte = tinyint de SQL Server
        public DateTime Fecha { get; set; }
        public int Expediente { get; set; }
        public int TipoConex { get; set; }
        public int TipoMedid { get; set; }
        public int TipoObraConex { get; set; }
        public decimal PotenciaHP { get; set; }
        public string Dias { get; set; }
        public string Iniciador { get; set; }
        public string Domicilio { get; set; }
        public int Localidad { get; set; }
        public int Inspector { get; set; }
        public string Observaciones { get; set; }
        public string Comprobante { get; set; }
        public decimal Importe { get; set; }
        public int UsuarioCrea { get; set; }
        public DateTime FechaCrea { get; set; }
        public int UsuarioModif { get; set; }
        public DateTime FechaUltModif { get; set; }
    }
}
