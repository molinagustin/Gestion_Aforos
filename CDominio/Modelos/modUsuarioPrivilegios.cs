using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDominio.Modelos
{
    public class modUsuarioPrivilegios
    {
        //Campos
        private int _IdPriv;
        private string _Descripcion;
        private bool _Activo;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        //Propiedades
        public int IdPriv { get => _IdPriv; set => _IdPriv = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
    }
}
