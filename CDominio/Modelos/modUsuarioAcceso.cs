using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDominio.Modelos
{
    public class modUsuarioAcceso
    {
        //Campos
        private int _IdUsAc;
        private bool _AfConexElect;
        private bool _ConexElect;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        //Propiedades
        public int IdUsAc { get => _IdUsAc; set => _IdUsAc = value; }
        public bool AfConexElect { get => _AfConexElect; set => _AfConexElect = value; }
        public bool ConexElect { get => _ConexElect; set => _ConexElect = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
    }
}
