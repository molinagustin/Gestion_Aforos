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
    public class modTipoConexion
    {
        #region Campos
        private int _IdTipoConex;
        private int _EstadoObra;
        private string _TipoConexion;
        private bool _Activo;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        private IRepositorioTipoConexion repositorioTipoConex;
        #endregion

        #region Propiedades
        public int IdTipoConex { get => _IdTipoConex; set => _IdTipoConex = value; }
        public int EstadoObra { get => _EstadoObra; set => _EstadoObra = value; }
        public string TipoConexion { get => _TipoConexion; set => _TipoConexion = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
        #endregion

        public modTipoConexion()
        {
            repositorioTipoConex = new repTipoConexion();
        }

        public List<modTipoConexion> obtenerTiposConexiones()
        {
            var enumTipoConex = repositorioTipoConex.ObtenerRegistros();
            var listaTiposConex = new List<modTipoConexion>();
            foreach (entTipoConexion tipoCon in enumTipoConex)
            {
                listaTiposConex.Add(new modTipoConexion { 
                    IdTipoConex = tipoCon.IdTipoConex,
                    EstadoObra = tipoCon.EstadoObra,
                    TipoConexion = tipoCon.TipoConexion,
                    Activo = tipoCon.Activo,
                    UsuarioCrea = tipoCon.UsuarioCrea,
                    FechaCrea = tipoCon.FechaCrea,
                    UsuarioModif = tipoCon.UsuarioModif,
                    FechaUltModif = tipoCon.FechaUltModif
                });
            }
            return listaTiposConex;
        }
    }
}
