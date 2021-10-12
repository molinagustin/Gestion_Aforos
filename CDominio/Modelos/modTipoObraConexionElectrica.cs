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
    public class modTipoObraConexionElectrica
    {
        #region Campos
        private int _IdTipoObAnex;
        private int _TipoObra;
        private string _TipoObraAnexa;
        private bool _Activo;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        private IRepositorioTipoObraConexionElectrica repositorioTipoObAnex;
        #endregion

        #region Propiedades
        public int IdTipoObAnex { get => _IdTipoObAnex; set => _IdTipoObAnex = value; }
        public int TipoObra { get => _TipoObra; set => _TipoObra = value; }
        public string TipoObraAnexa { get => _TipoObraAnexa; set => _TipoObraAnexa = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
        #endregion

        public modTipoObraConexionElectrica()
        {
            repositorioTipoObAnex = new repTipoObraConexionElectrica();
        }        

        public List<modTipoObraConexionElectrica> obtenerTiposObrasCE()
        {
            var enumTiposObCE = repositorioTipoObAnex.ObtenerRegistros();
            var listaTipoObCE = new List<modTipoObraConexionElectrica>();
            foreach (entTipoObraConexionElectrica tipoObCE in enumTiposObCE)
            {
                listaTipoObCE.Add(new modTipoObraConexionElectrica { 
                    IdTipoObAnex = tipoObCE.IdTipoObAnex,
                    TipoObra = tipoObCE.TipoObra,
                    TipoObraAnexa = tipoObCE.TipoObraAnexa,
                    Activo = tipoObCE.Activo,
                    UsuarioCrea = tipoObCE.UsuarioCrea,
                    FechaCrea = tipoObCE.FechaCrea,
                    UsuarioModif = tipoObCE.UsuarioModif,
                    FechaUltModif = tipoObCE.FechaUltModif
                });
            }
            return listaTipoObCE;
        }
    }
}
