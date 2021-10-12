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
    public class modTipoMedidor
    {
        #region Campos
        private int _IdTipoMed;
        private string _TipoMedidor;
        private bool _Activo;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        private IRepositorioTipoMedidor repositorioTipoMed;
        #endregion

        #region Propiedades
        public int IdTipoMed { get => _IdTipoMed; set => _IdTipoMed = value; }
        public string TipoMedidor { get => _TipoMedidor; set => _TipoMedidor = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
        #endregion

        public modTipoMedidor()
        {
            repositorioTipoMed = new repTipoMedidor();
        }

        public List<modTipoMedidor> obtenerTiposMedidores()
        {
            var enumTipoMed = repositorioTipoMed.ObtenerRegistros();
            var listaTipoMed = new List<modTipoMedidor>();
            foreach (entTipoMedidor tipoMed in enumTipoMed)
            {
                listaTipoMed.Add(new modTipoMedidor { 
                    IdTipoMed = tipoMed.IdTipoMed,
                    TipoMedidor = tipoMed.TipoMedidor,
                    Activo = tipoMed.Activo,
                    UsuarioCrea = tipoMed.UsuarioCrea,
                    FechaCrea = tipoMed.FechaCrea,
                    UsuarioModif = tipoMed.UsuarioModif,
                    FechaUltModif = tipoMed.FechaUltModif
                });
            }
            return listaTipoMed;
        }
    }
}
