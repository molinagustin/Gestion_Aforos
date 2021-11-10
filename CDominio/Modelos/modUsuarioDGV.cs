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
    public class modUsuarioDGV
    {
        #region Campos        
        private string _CUIL;
        private string _NombreUs;
        private string _Apellido;
        private string _Nombre;
        private bool _Activo;
        private string _UsuarioCrea;
        private DateTime _FechaCrea;
        private string _UsuarioModif;
        private DateTime _FechaUltModif;

        private IRepositorioUsuario repoUsu;
        #endregion

        #region Propiedades
        public string CUIL { get => _CUIL; set => _CUIL = value; }
        public string NombreUs { get => _NombreUs; set => _NombreUs = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }
        public string UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public string UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
        #endregion

        public modUsuarioDGV()
        {
            repoUsu = new repUsuario();
        }

        public List<modUsuarioDGV> ObtUsuDGV()
        {
            var tabla = repoUsu.ObtenerUsuariosDGV();
            var listaUsuDGV = new List<modUsuarioDGV>();
            foreach (DataRow fila in tabla.Rows)
            {
                listaUsuDGV.Add(new modUsuarioDGV
                {
                    CUIL = fila[0].ToString(),
                    NombreUs = fila[1].ToString(),
                    Apellido = fila[2].ToString(),
                    Nombre = fila[3].ToString(),
                    Activo = Convert.ToBoolean(fila[4]),
                    UsuarioCrea = fila[5].ToString(),
                    FechaCrea = Convert.ToDateTime(fila[6]),
                    UsuarioModif = fila[7].ToString(),
                    FechaUltModif = Convert.ToDateTime(fila[8])
                });
            }

            return listaUsuDGV;
        }
    }
}
