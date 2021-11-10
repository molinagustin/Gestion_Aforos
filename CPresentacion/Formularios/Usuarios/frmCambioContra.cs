using CDominio.Modelos;
using CDominio.ObjetosDeValor;
using SimpleCrypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.Formularios.Usuarios
{
    public partial class frmCambioContra : Form
    {
        public frmCambioContra()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomUsuario = txtNombreUs.Texts.Trim();
                string passAct = txtContraActual.Texts.Trim();
                string passNuevo = txtNuevaContra.Texts.Trim();
                string passNuevo2 = txtRepContra.Texts.Trim();

                if (nomUsuario != string.Empty && passAct != string.Empty && passNuevo != string.Empty && passNuevo2 != string.Empty)
                {
                    if (passNuevo == passNuevo2)
                    {
                        if (passNuevo != passAct)
                        {
                            modUsuario usuario = new modUsuario();
                            usuario = usuario.ObtenerUsuario(nomUsuario);

                            if (usuario.IdUsuarioAct > 0)
                            {
                                PBKDF2 cryptoService = new PBKDF2();
                                string hashPass = cryptoService.Compute(passAct, usuario.SaltCont);

                                if (cryptoService.Compare(usuario.HashCont, hashPass))
                                {
                                    if (usuario.Activo)
                                    {
                                        string salt = cryptoService.GenerateSalt();
                                        string hash = cryptoService.Compute(passNuevo);

                                        usuario.SaltCont = salt;
                                        usuario.HashCont = hash;
                                        usuario.UsuarioModif = usuario.IdUsuarioAct;
                                        usuario.FechaUltModif = DateTime.Now;
                                        usuario.estado = EstadoEntidad.Modificar;

                                        if (usuario.GuardarCambios() > 0)
                                            this.DialogResult = DialogResult.OK;
                                        else
                                            throw new Exception("No se pudo modificar la contraseña, compruebe los caracteres ingresados o contacte al administrador.");
                                    }
                                    else
                                        throw new Exception("El usuario no se encuentra activo.");
                                }
                                else
                                    throw new Exception("La contraseña ingresada es incorrecta.");
                            }
                            else
                                throw new Exception("El usuario ingresado no es correcto.");
                        }
                        else
                            throw new Exception("La nueva contraseña debe ser distinta a la actual.");
                    }
                    else
                        throw new Exception("Las contraseñas nuevas deben ser identicas.");
                }
                else
                    throw new Exception("Debe completar todos los campos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cambio Contraseña");
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void soloLetras(KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar)) || (e.KeyChar == Convert.ToChar(".")) || (e.KeyChar == Convert.ToChar(",")))
                e.Handled = true;
        }

        private void txtNombreUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }
    }
}
