using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDominio.Modelos;

namespace CPresentacion.Formularios.Usuarios
{
    public partial class frmConsultaModif : Form
    {
        #region Campos        
        modUsuario usu = new modUsuario();
        modUsuarioDGV usuDGV = new modUsuarioDGV();

        List<modUsuarioPrivilegios> privilegios = new List<modUsuarioPrivilegios>();
        List<modUsuarioAcceso> accesos = new List<modUsuarioAcceso>();
        List<modUsuario> usuarios = new List<modUsuario>();
        List<modUsuarioDGV> usDGV = new List<modUsuarioDGV>();

        private int numUsSelect = -1;
        #endregion

        public frmConsultaModif()
        {
            InitializeComponent();
            privilegios = usu.ObtenerPrivilegios();
            accesos = usu.ObtenerAccesos();
            usuarios = usu.ObtenerUsuarios();
            usDGV = usuDGV.ObtUsuDGV();
        }

        private void frmConsultaModif_Load(object sender, EventArgs e)
        {
            //Cargar CBO
            cboTipoUs.ValueMember = "IdPriv";
            cboTipoUs.DisplayMember = "Descripcion";
            cboTipoUs.DataSource = privilegios;

            //Cargar DGV
            dgvListadoUsuarios.DataSource = usDGV;
        }

        #region Metodos

        #endregion

        #region Eventos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion        
    }
}
