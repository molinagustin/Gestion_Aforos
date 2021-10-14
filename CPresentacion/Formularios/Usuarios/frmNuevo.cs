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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string contrasenia = txtPass1.Texts.Trim();

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

            string resultado = nuevoUsuario.GuardarCambios();
            MessageBox.Show(resultado);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
