using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SimpleCrypto;
using CPresentacion.Formularios.Principal;
using CDominio.Modelos;
using CComun.Cache;

namespace CPresentacion.Formularios.Usuarios
{
    public partial class frmLogin : Form
    {       
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomUsuario = txtUsuario.Texts.Trim();
                string pass = txtPass.Texts.Trim();

                if (nomUsuario != string.Empty && pass != string.Empty)
                {
                    modUsuario usuario = new modUsuario();
                    usuario = usuario.ObtenerUsuario(nomUsuario);
                    
                    if (usuario.IdUsuarioAct > 0)
                    {
                        PBKDF2 cryptoService = new PBKDF2();
                        string hashPass = cryptoService.Compute(pass, usuario.SaltCont);

                        if (cryptoService.Compare(usuario.HashCont, hashPass))
                        {
                            if (usuario.Activo)
                            {
                                this.Hide();

                                cacUsuario.IdUsuarioAct = usuario.IdUsuarioAct;
                                cacUsuario.NombreUs = usuario.NombreUs;
                                cacUsuario.Apellido = usuario.Apellido;
                                cacUsuario.Nombre = usuario.Nombre;
                                cacUsuario.Privilegio = usuario.Privilegio;
                                cacUsuario.Acceso = usuario.Acceso;
                                usuario.EstablecerAccesos(usuario.Acceso);

                                frmPrincipal MenuPrincipal = new frmPrincipal();
                                MenuPrincipal.Show();
                            }
                            else
                                throw new Exception("El usuario no se encuentra activo, contactar al administrador.");
                        }
                        else
                            throw new Exception("Usuario y/o contraseña incorrecto.");
                    }
                    else
                        throw new Exception("Usuario y/o contraseña incorrecto.");
                }
                else
                    throw new Exception("Campos incompletos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
