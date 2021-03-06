using CAccesoDatos.Contratos;
using CAccesoDatos.Entidades;
using CAccesoDatos.Repositorios;
using CDominio.ObjetosDeValor;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CDominio.Modelos
{
    public class modUsuario
    {
        #region Campos
        private int _IdUsuarioAct;
        private string _CUIL;
        private string _NombreUs;
        private string _Apellido;
        private string _Nombre;
        private string _SaltCont;
        private string _HashCont;
        private int _Privilegio;
        private int _Acceso;
        private bool _Activo;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        //Se crea un campo al repositorio para asi obtener el acceso tanto a los metodos del usuario y los metodos genericos heredados desde la interfaz generica
        private IRepositorioUsuario repositorioUsuario;
        #endregion

        #region Propiedades
        //Estado para definir si es Agregar, Modificar o Eliminar
        public EstadoEntidad estado { private get; set; }
        public int IdUsuarioAct { get => _IdUsuarioAct; set => _IdUsuarioAct = value; }
        public string CUIL { get => _CUIL; set => _CUIL = value; }
        public string NombreUs
        {
            get => _NombreUs; 
            set
            {
                if (value == null)
                    _NombreUs = value;                
                else if (value.Length >= 4)
                    _NombreUs = value;
                else
                    throw new Exception("El nombre de usuario debe ser de 4 caracteres minimo.");
            }
        }
        public string Apellido
        {
            get => _Apellido; 
            set
            {
                if (value == null)
                    _Apellido = value;                
                else if (value.Length > 0)
                    _Apellido = value;
                else
                    throw new Exception("Se debe colocar el apellido del usuario.");
            }
        }
        public string Nombre
        {
            get => _Nombre; 
            set
            {
                if (value == null)
                    _Nombre = value;                
                else if (value.Length > 0)
                    _Nombre = value;
                else
                    throw new Exception("Se debe colocar el nombre del usuario.");
            }
        }
        public string SaltCont { get => _SaltCont; set => _SaltCont = value; }
        public string HashCont { get => _HashCont; set => _HashCont = value; }
        public int Privilegio { get => _Privilegio; set => _Privilegio = value; }
        public int Acceso { get => _Acceso; set => _Acceso = value; }
        public bool Activo { get => _Activo; set => _Activo = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
        #endregion

        public modUsuario()
        {
            //No utlizamos la interfaz, sino que le asignamos una instancia del Repositorio Usuario
            repositorioUsuario = new repUsuario();
        }

        public int GuardarCambios()
        {
            int status = 0;

            //Creamos una instancia de la Entidad Usuario y le asignamos los valores de las propiedades de este modelo
            var usuario = new entUsuario();
            usuario.IdUsuarioAct = IdUsuarioAct;
            usuario.CUIL = CUIL;
            usuario.NombreUs = NombreUs;
            usuario.Apellido = Apellido;
            usuario.Nombre = Nombre;
            usuario.SaltCont = SaltCont;
            usuario.HashCont = HashCont;
            usuario.Privilegio = Privilegio;
            usuario.Acceso = Acceso;
            usuario.Activo = Activo;
            usuario.UsuarioCrea = UsuarioCrea;
            usuario.FechaCrea = FechaCrea;
            usuario.UsuarioModif = UsuarioModif;
            usuario.FechaUltModif = FechaUltModif;

            //En base al estado, sera la operacion a realizar
            switch (estado)
            {
                case EstadoEntidad.Agregar:
                    //De ser necesario, agregar antes los metodos para realizar comprobaciones o calculos
                    status = repositorioUsuario.Agregar(usuario);
                    return status;

                case EstadoEntidad.Modificar:
                    status = repositorioUsuario.Editar(usuario);
                    return status;

                case EstadoEntidad.Eliminar:
                    status = repositorioUsuario.Eliminar(IdUsuarioAct);
                    return status;

                default:
                    return status;
            }        
        }

        public List<modUsuario> ObtenerUsuarios()
        {
            var enumerableUsuarios = repositorioUsuario.ObtenerRegistros();
            var listaUsuarios = new List<modUsuario>();
            foreach (entUsuario user in enumerableUsuarios)
            {
                listaUsuarios.Add(CrearNuevoModUsuario(user));
            }
            return listaUsuarios;
        }

        public List<modUsuarioPrivilegios> ObtenerPrivilegios()
        {
            var enumerablePrivilegios = repositorioUsuario.ObtenerPrivilegios();
            var listaPrivilegios = new List<modUsuarioPrivilegios>();
            foreach (entUsuarioPrivilegios privilegio in enumerablePrivilegios)
            {
                listaPrivilegios.Add(new modUsuarioPrivilegios
                {
                    IdPriv = privilegio.IdPriv,
                    Descripcion = privilegio.Descripcion,
                    Activo = privilegio.Activo,
                    UsuarioCrea = privilegio.UsuarioCrea,
                    FechaCrea = privilegio.FechaCrea,
                    UsuarioModif = privilegio.UsuarioModif,
                    FechaUltModif = privilegio.FechaUltModif
                });
            }

            return listaPrivilegios;
        }

        public List<modUsuarioAcceso> ObtenerAccesos()
        {
            var enumerableAccesos = repositorioUsuario.ObtenerAccesos();
            var listaAccesos = new List<modUsuarioAcceso>();
            foreach (entUsuarioAcceso acce in enumerableAccesos)
            {
                listaAccesos.Add(new modUsuarioAcceso
                {
                    IdUsAc = acce.IdUsAc,
                    AfConexElect = acce.AfConexElect,
                    ConexElect = acce.ConexElect,
                    UsuarioCrea = acce.UsuarioCrea,
                    FechaCrea = acce.FechaCrea,
                    UsuarioModif = acce.UsuarioModif,
                    FechaUltModif = acce.FechaUltModif
                });
            }

            return listaAccesos;
        }

        public modUsuario ObtenerUsuario(int idUsuario)
        {
            entUsuario user = repositorioUsuario.ObtenerUsuarioPorId(idUsuario);
            return CrearNuevoModUsuario(user);
        }

        public modUsuario ObtenerUsuario(string nombreUsuario)
        {
            entUsuario user = repositorioUsuario.ObtenerUsuarioPorNombreUsuario(nombreUsuario);
            return CrearNuevoModUsuario(user);
        }

        public int AgregarAcceso(bool afConexElect, bool conexElect)
        {
            return repositorioUsuario.InsertarNuevoAcceso(afConexElect, conexElect);
        }

        public void EstablecerAccesos(int idAcceso)
        {
            repositorioUsuario.EstablecerCacheAccesosUsuario(idAcceso);
        }

        private modUsuario CrearNuevoModUsuario(entUsuario user)
        {
            modUsuario nuevoModUsuario = new modUsuario();
            nuevoModUsuario.IdUsuarioAct = user.IdUsuarioAct;
            nuevoModUsuario.CUIL = user.CUIL;
            nuevoModUsuario.NombreUs = user.NombreUs;
            nuevoModUsuario.Apellido = user.Apellido;
            nuevoModUsuario.Nombre = user.Nombre;
            nuevoModUsuario.SaltCont = user.SaltCont;
            nuevoModUsuario.HashCont = user.HashCont;
            nuevoModUsuario.Privilegio = user.Privilegio;
            nuevoModUsuario.Acceso = user.Acceso;
            nuevoModUsuario.Activo = user.Activo;
            nuevoModUsuario.UsuarioCrea = user.UsuarioCrea;
            nuevoModUsuario.FechaCrea = user.FechaCrea;
            nuevoModUsuario.UsuarioModif = user.UsuarioModif;
            nuevoModUsuario.FechaUltModif = user.FechaUltModif;
            return nuevoModUsuario;
        }
    }
}
