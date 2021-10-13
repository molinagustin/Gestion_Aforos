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
    public class modPermisoElectrico
    {
        #region Campos
        private int _NumPermiso;
        private byte _Acronimo;
        private DateTime _Fecha;
        private int _Expediente;
        private int _TipoConex;
        private int _TipoMedid;
        private int _TipoObraConex;
        private decimal _PotenciaHP;
        private string _Dias;
        private string _Iniciador;
        private string _Domicilio;
        private int _Localidad;
        private int _Inspector;
        private string _Observaciones;
        private string _Comprobante;
        private decimal _Importe;
        private int _UsuarioCrea;
        private DateTime _FechaCrea;
        private int _UsuarioModif;
        private DateTime _FechaUltModif;

        private IRepositorioPermisoElectrico repositorioPE;
        #endregion

        #region Propiedades
        public EstadoEntidad estado { private get; set; }
        public int NumPermiso { get => _NumPermiso; set => _NumPermiso = value; }
        public byte Acronimo { get => _Acronimo; set => _Acronimo = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int Expediente { get => _Expediente; set => _Expediente = value; }
        public int TipoConex { get => _TipoConex; set => _TipoConex = value; }
        public int TipoMedid { get => _TipoMedid; set => _TipoMedid = value; }
        public int TipoObraConex { get => _TipoObraConex; set => _TipoObraConex = value; }
        public decimal PotenciaHP { get => _PotenciaHP; set => _PotenciaHP = value; }
        public string Dias { get => _Dias; set => _Dias = value; }
        public string Iniciador { get => _Iniciador; set => _Iniciador = value; }
        public string Domicilio { get => _Domicilio; set => _Domicilio = value; }
        public int Localidad { get => _Localidad; set => _Localidad = value; }
        public int Inspector { get => _Inspector; set => _Inspector = value; }
        public string Observaciones { get => _Observaciones; set => _Observaciones = value; }
        public string Comprobante { get => _Comprobante; set => _Comprobante = value; }
        public decimal Importe { get => _Importe; set => _Importe = value; }
        public int UsuarioCrea { get => _UsuarioCrea; set => _UsuarioCrea = value; }
        public DateTime FechaCrea { get => _FechaCrea; set => _FechaCrea = value; }
        public int UsuarioModif { get => _UsuarioModif; set => _UsuarioModif = value; }
        public DateTime FechaUltModif { get => _FechaUltModif; set => _FechaUltModif = value; }
        #endregion

        #region Metodos
        public modPermisoElectrico()
        {
            repositorioPE = new repPermisoElectrico();
        }

        public string GuardarCambios()
        {
            string mensaje = "";

            try
            {
                var permisoCE = new entPermisoElectrico();
                permisoCE.NumPermiso = NumPermiso;
                permisoCE.Acronimo = Acronimo;
                permisoCE.Fecha = Fecha;
                permisoCE.Expediente = Expediente;
                permisoCE.TipoConex = TipoConex;
                permisoCE.TipoMedid = TipoMedid;
                permisoCE.TipoObraConex = TipoObraConex;
                permisoCE.PotenciaHP = PotenciaHP;
                permisoCE.Dias = Dias;
                permisoCE.Iniciador = Iniciador;
                permisoCE.Domicilio = Domicilio;
                permisoCE.Localidad = Localidad;
                permisoCE.Inspector = Inspector;
                permisoCE.Observaciones = Observaciones;
                permisoCE.Comprobante = Comprobante;
                permisoCE.Importe = Importe;
                permisoCE.UsuarioCrea = UsuarioCrea;
                permisoCE.FechaCrea = FechaCrea;
                permisoCE.UsuarioModif = UsuarioModif;
                permisoCE.FechaUltModif = FechaUltModif;

                switch (estado)
                {
                    case EstadoEntidad.Agregar:
                        //De ser necesario, agregar antes los metodos para realizar comprobaciones o calculos
                        var numPermiso = repositorioPE.Agregar(permisoCE);
                        if (numPermiso > 0)
                            mensaje = "Se genero correctamente el permiso n° " + numPermiso;
                        else
                            mensaje = "No se pudo generar el permiso";
                        break;

                    case EstadoEntidad.Modificar:
                        throw new NotImplementedException();
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;                
            }

            return mensaje;
        }
        #endregion
    }
}
