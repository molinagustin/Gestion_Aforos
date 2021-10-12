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
    public class modLocalidad
    {
        #region Campos
        private int _IdLoc;
        private string _Localidad;
        private string _CP;
        private bool _Activo;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        private IRepositorioLocalidad repositorioLoc;
        #endregion

        #region Propiedades
        public int IdLoc { get => _IdLoc; set => _IdLoc = value; }
        public string Localidad { get => _Localidad; set => _Localidad = value; }
        public string CP { get => _CP; set => _CP = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
        #endregion

        public modLocalidad()
        {
            repositorioLoc = new repLocalidad();
        }

        public List<modLocalidad> obtenerLocalidades()
        {
            var enumLocalidades = repositorioLoc.ObtenerRegistros();
            var listaLoc = new List<modLocalidad>();
            foreach (entLocalidad loc in enumLocalidades)
            {
                listaLoc.Add(new modLocalidad {
                    IdLoc = loc.IdLoc,
                    Localidad = loc.Localidad,
                    CP = loc.CP,
                    Activo = loc.Activo,
                    UsuarioCrea = loc.UsuarioCrea,
                    FechaCrea = loc.FechaCrea,
                    UsuarioModif = loc.UsuarioModif,
                    FechaUltModif = loc.FechaUltModif
                });
            }
            return listaLoc;
        }
    }
}
