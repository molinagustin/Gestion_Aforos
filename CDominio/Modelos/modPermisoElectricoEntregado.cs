using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAccesoDatos.Contratos;
using CAccesoDatos.Entidades;
using CAccesoDatos.Repositorios;

namespace CDominio.Modelos
{
    public class modPermisoElectricoEntregado
    {
        #region Campos
        private int _NumPermiso;
        private DateTime _Fecha;
        private string _UsuarioCrea;
        private DateTime _FechaCrea;
        private string _UsuarioModif;
        private DateTime _FechaUltModif;

        private IRepositorioPermisoElectrico repoPCE;
        #endregion

        #region Propiedades
        public int NumPermiso { get => _NumPermiso; set => _NumPermiso = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public string UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
        #endregion

        public modPermisoElectricoEntregado()
        {
            repoPCE = new repPermisoElectrico();
        }        

        public List<modPermisoElectricoEntregado> ObtenerPermisosElect()
        {
            var tabla = repoPCE.PermisosGenerados();
            var listaPCE = new List<modPermisoElectricoEntregado>();
            foreach (DataRow fila in tabla.Rows)
            {
                listaPCE.Add(new modPermisoElectricoEntregado { 
                    NumPermiso = Convert.ToInt32(fila[0]),
                    Fecha = Convert.ToDateTime(fila[1]),
                    UsuarioCrea = fila[2].ToString(),
                    FechaCrea = Convert.ToDateTime(fila[3]),
                    UsuarioModif = fila[4].ToString(),
                    FechaUltModif = Convert.ToDateTime(fila[5])
                });
            }
            return listaPCE;
        }
    }
}
