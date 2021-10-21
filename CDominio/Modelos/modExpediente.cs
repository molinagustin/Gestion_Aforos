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
    public class modExpediente
    {
        #region Campos
        private int _IdExpte;
        private string _Letra;
        private string _Anio;
        private string _Numero;
        private string _Iniciador;
        private string _Caratula;
        private bool _Activo;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        private IRepositorioExpediente repositorioExpte;
        #endregion

        #region Propiedades
        public int IdExpte { get => _IdExpte; set => _IdExpte = value; }
        public string Letra
        {
            get => _Letra; 
            set
            {
                if (value.Length > 0)
                    _Letra = value;
                else
                    _Letra = "XXX";
            }
        }
        public string Anio
        {
            get => _Anio; 
            set
            {
                if (value != null && value != "")
                    _Anio = value;
                else
                    throw new Exception("Se debe colocar un valor para el año del expediente.");
            }
        }
        public string Numero
        {
            get => _Numero; 
            set
            {
                if (value != null && value != "")
                    _Numero = value;
                else
                    throw new Exception("Se debe colocar un valor para el numero del expediente.");
            }
        }
        public string Iniciador { get => _Iniciador; set => _Iniciador = value; }
        public string Caratula { get => _Caratula; set => _Caratula = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
        #endregion

       public modExpediente()
        {
            repositorioExpte = new repExpediente();
        }

        public int AgregarExpte()
        {
            entExpediente expte = new entExpediente();
            expte.IdExpte = IdExpte;
            expte.Letra = Letra;
            expte.Anio = Anio;
            expte.Numero = Numero;
            expte.Iniciador = Iniciador;
            expte.Caratula = Caratula;
            expte.Activo = Activo;
            expte.UsuarioCrea = UsuarioCrea;
            expte.FechaCrea = FechaCrea;
            expte.UsuarioModif = UsuarioModif;
            expte.FechaUltModif = FechaUltModif;

            return repositorioExpte.Agregar(expte);
        }

        public List<modExpediente> ObtenerExpedientes()
        {
            var enumExpts = repositorioExpte.ObtenerRegistros();
            var listaExpts = new List<modExpediente>();
            foreach (entExpediente exp in enumExpts)
            {
                listaExpts.Add(new modExpediente { 
                    IdExpte = exp.IdExpte,
                    Letra = exp.Letra,
                    Anio = exp.Anio,
                    Numero = exp.Numero,
                    Iniciador = exp.Iniciador,
                    Caratula = exp.Caratula,
                    Activo = exp.Activo,
                    UsuarioCrea = exp.UsuarioCrea,
                    FechaCrea = exp.FechaCrea,
                    UsuarioModif = exp.UsuarioModif,
                    FechaUltModif = exp.FechaUltModif
                });
            }
            return listaExpts;
        }
    }
}
