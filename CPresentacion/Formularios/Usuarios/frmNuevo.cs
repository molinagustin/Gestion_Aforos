using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CComun.Cache;
using CDominio.Modelos;
using CDominio.ObjetosDeValor;
using SimpleCrypto;

namespace CPresentacion.Formularios.Usuarios
{
    public partial class frmNuevo : Form
    {
        private modUsuario usuario = new modUsuario();

        public frmNuevo()
        {
            InitializeComponent();
        }

        private void frmNuevo_Load(object sender, EventArgs e)
        {
            //Combobox Privilegios
            cboTipoUs.ValueMember = "IdPriv";
            cboTipoUs.DisplayMember = "Descripcion";            
            cboTipoUs.DataSource = usuario.ObtenerPrivilegios(); 
        }

        #region Metodos
        private void soloNumero(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void soloLetras(KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar)) || (e.KeyChar == Convert.ToChar(".")) || (e.KeyChar == Convert.ToChar(",")))
                e.Handled = true;
        }

        private void limpiarControles()
        {
            txtCuil.Texts = "";
            txtApellido.Texts = "";
            txtNombre.Texts = "";
            txtNombreUs.Texts = "";
            txtPass1.Texts = "";
            txtPass2.Texts = "";
            cboTipoUs.SelectedIndex = 0;
            chkAfoElect.Checked = false;
            chkPermisosElect.Checked = false;
        }
        #endregion

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string contrasenia = txtPass1.Texts.Trim();
                string contrasenia2 = txtPass2.Texts.Trim();

                if (contrasenia == contrasenia2)
                {
                    if (contrasenia != "" && contrasenia2 != "")
                    {
                        if (contrasenia.Length >= 4 && contrasenia2.Length >= 4)
                        {
                            modUsuario nuevoUsuario = new modUsuario();
                            int valorCbo = Convert.ToInt32(cboTipoUs.SelectedValue);
                            int nuevoAcceso = nuevoUsuario.AgregarAcceso(chkAfoElect.Checked, chkPermisosElect.Checked);

                            PBKDF2 cryptoService = new PBKDF2();
                            string salt = cryptoService.GenerateSalt();
                            string hash = cryptoService.Compute(contrasenia);

                            nuevoUsuario.CUIL = txtCuil.Texts.Trim();
                            nuevoUsuario.NombreUs = txtNombreUs.Texts.Trim();
                            nuevoUsuario.Apellido = txtApellido.Texts.Trim();
                            nuevoUsuario.Nombre = txtNombre.Texts.Trim();
                            nuevoUsuario.SaltCont = salt;
                            nuevoUsuario.HashCont = hash;
                            nuevoUsuario.Privilegio = valorCbo;
                            nuevoUsuario.Acceso = nuevoAcceso;
                            nuevoUsuario.Activo = true;
                            nuevoUsuario.UsuarioCrea = cacUsuario.IdUsuarioAct;
                            nuevoUsuario.FechaCrea = DateTime.Now;
                            nuevoUsuario.UsuarioModif = cacUsuario.IdUsuarioAct;
                            nuevoUsuario.FechaUltModif = DateTime.Now;
                            nuevoUsuario.estado = EstadoEntidad.Agregar;

                            if (nuevoUsuario.GuardarCambios() > 0)
                            {
                                MessageBox.Show("Se agrego el nuevo usuario de forma exitosa.", "Alta Usuario");
                                if (MessageBox.Show("¿Desea limpiar los formularios?", "Alta Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    limpiarControles();
                            }
                            else
                                throw new Exception("No se pudo realizar la carga del nuevo registro, por favor verifique los campos completados.");
                        }
                        else
                            throw new Exception("La contraseña debe ser minimo de 4 caracteres.");
                    }
                    else
                        throw new Exception("Las contraseñas no pueden estar vacias.");
                }
                else
                    throw new Exception("Las contraseñas deben ser iguales.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alta Usuario");
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtNombreUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            txtApellido.Texts = txtApellido.Texts.ToUpper();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtNombre.Texts = txtNombre.Texts.ToUpper();
        }
        #endregion
    }
}
