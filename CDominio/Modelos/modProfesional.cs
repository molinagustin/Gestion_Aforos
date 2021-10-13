using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAccesoDatos.Contratos;
using CAccesoDatos.Entidades;
using CAccesoDatos.Repositorios;
using CDominio.ObjetosDeValor;
namespace CDominio.Modelos
{
    public class modProfesional
    {
        #region Campos
        private int _IdProf;
        private string _CUIL;
        private string _Apellido;
        private string _Nombre;
        private int _Profesion;
        private bool _Inspector;
        private bool _Electricista;
        private string _Email;
        private string _Telefono;
        private bool _Activo;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        //Genero un campo para el nombre completo que viene creado en el repositorio pero no se guarda en la base datos
        private string _NombreCompleto;
        private IRepositorioProfesional repositorioProf;
        #endregion

        #region Propiedades
        public EstadoEntidad estado { private get; set; }
        public int IdProf { get => _IdProf; set => _IdProf = value; }
        public string CUIL { get => _CUIL; set => _CUIL = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Profesion { get => _Profesion; set => _Profesion = value; }
        public bool Inspector { get => _Inspector; set => _Inspector = value; }
        public bool Electricista { get => _Electricista; set => _Electricista = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }

        //Propiedad que no hace falta guardar
        public string NombreCompleto { get => _NombreCompleto; private set => _NombreCompleto = value; }
        #endregion

        public modProfesional()
        {
            repositorioProf = new repProfesional();
        }

        public List<modProfesional> ObtenerInspectores()
        {
            var enumProf = repositorioProf.ObtenerProfesionalesInspectoresElectricos();
            var listaProf = new List<modProfesional>();
            foreach (entProfesional prof in enumProf)
            {
                listaProf.Add(new modProfesional { 
                    IdProf = prof.IdProf,
                    CUIL = prof.CUIL,
                    Apellido = prof.Apellido,
                    Nombre = prof.Nombre,
                    Profesion = prof.Profesion,
                    Inspector = prof.Inspector,
                    Electricista = prof.Electricista,
                    Email = prof.Email,
                    Telefono = prof.Telefono,
                    Activo = prof.Activo,
                    UsuarioCrea = prof.UsuarioCrea,
                    FechaCrea = prof.FechaCrea,
                    UsuarioModif = prof.UsuarioModif,
                    FechaUltModif = prof.FechaUltModif,    
                    NombreCompleto = prof.NombreCompleto
                });
            }
            return listaProf;
        }
    }
}
