using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAccesoDatos.Contratos;
using CAccesoDatos.Entidades;
using CAccesoDatos.Repositorios;

namespace CDominio.Modelos
{
    public class modAcronimo
    {
        #region Campos
        private byte _IdAcron;
        private string _Acronimo;
        private string _Descripcion;
        private bool _Activo;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        private IRepositorioAcronimo repositorioAcro;
        #endregion

        #region Propiedades
        public byte IdAcron { get => _IdAcron; set => _IdAcron = value; }
        public string Acronimo { get => _Acronimo; set => _Acronimo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
        #endregion

        public modAcronimo()
        {
            repositorioAcro = new repAcronimo();
        }        

        public List<modAcronimo> ObtenerAcronimos()
        {
            var enumAcros = repositorioAcro.ObtenerRegistros();
            var listaAcros = new List<modAcronimo>();
            foreach (entAcronimo acro in enumAcros)
            {
                listaAcros.Add(new modAcronimo {
                    IdAcron = acro.IdAcron,
                    Acronimo = acro.Acronimo,
                    Descripcion = acro.Descripcion,
                    Activo = acro.Activo,
                    UsuarioCrea = acro.UsuarioCrea,
                    FechaCrea = acro.FechaCrea,
                    UsuarioModif = acro.UsuarioModif,
                    FechaUltModif = acro.FechaUltModif
                });
            }
            return listaAcros;
        }
    }
}
