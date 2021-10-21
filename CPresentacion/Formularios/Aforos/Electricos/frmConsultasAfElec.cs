using CDominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.Formularios.Aforos.Electricos
{
    public partial class frmConsultasAfElec : Form
    {
        //Campos
        modTipoConexion tipoCon = new modTipoConexion();
        modTipoMedidor tipoMed = new modTipoMedidor();
        modTipoObraConexionElectrica tipoObCE = new modTipoObraConexionElectrica();
        modLocalidad localidades = new modLocalidad();
        modProfesional inspectores = new modProfesional();
        modAcronimo acronimos = new modAcronimo();
        modPermisoElectricoEntregado permisosCEEnt = new modPermisoElectricoEntregado();
        modPermisoElectrico permisoElect = new modPermisoElectrico();
        modExpediente expediente = new modExpediente();

        List<modAcronimo> datosAcros = new List<modAcronimo>();
        List<modPermisoElectricoEntregado> permisosEntregados = new List<modPermisoElectricoEntregado>();
        List<modPermisoElectrico> permisosElectricos = new List<modPermisoElectrico>();
        List<modExpediente> expedientes = new List<modExpediente>();

        private int numPerSelect = -1;

        public frmConsultasAfElec()
        {
            InitializeComponent();
            datosAcros = acronimos.ObtenerAcronimos();
            permisosEntregados = permisosCEEnt.ObtenerPermisosElect();
            permisosElectricos = permisoElect.ObtenerPermisos();
            expedientes = expediente.ObtenerExpedientes();
        }

        private void frmConsultasAfElec_Load(object sender, EventArgs e)
        {
            CargarCbos();
        }

        public void CargarCbos()
        {
            //Tipos Conexiones -> Filtro per medio de FindAll para que el modTipoConexiones sea del Id 2 o 4 (No Definitiva o Definitiva)
            cboTipoConex.ValueMember = "IdTipoConex";
            cboTipoConex.DisplayMember = "TipoConexion";
            cboTipoConex.DataSource = tipoCon.obtenerTiposConexiones().FindAll(e => e.IdTipoConex == 2 || e.IdTipoConex == 4);

            //Tipos Medidores
            cboTipoMed.ValueMember = "IdTipoMed";
            cboTipoMed.DisplayMember = "TipoMedidor";
            cboTipoMed.DataSource = tipoMed.obtenerTiposMedidores();

            //Tipos Obras Conexiones Electricas
            cboTipoObraConex.ValueMember = "IdTipoObAnex";
            cboTipoObraConex.DisplayMember = "TipoObraAnexa";
            cboTipoObraConex.DataSource = tipoObCE.obtenerTiposObrasCE();

            //Localidades
            cboLocalidad.ValueMember = "IdLoc";
            cboLocalidad.DisplayMember = "Localidad";
            cboLocalidad.DataSource = localidades.obtenerLocalidades();

            //Inspectores
            cboInspector.ValueMember = "IdProf";
            cboInspector.DisplayMember = "NombreCompleto";
            cboInspector.DataSource = inspectores.ObtenerInspectores();

            //Acronimos
            cboTipoAforo.ValueMember = "IdAcron";
            cboTipoAforo.DisplayMember = "Acronimo";
            cboTipoAforo.DataSource = acronimos.ObtenerAcronimos();
            cboTipoAforo.SelectedIndex = 1;
        }

        public void CargarCbos(int tipoCon, int tipoMed, int tipoObCE, int localidad, int inspector)
        {
            cboTipoConex.SelectedValue = tipoCon;
            cboTipoMed.SelectedValue = tipoMed;
            cboTipoObraConex.SelectedValue = tipoObCE;
            cboLocalidad.SelectedValue = localidad;
            cboInspector.SelectedValue = inspector;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (numPerSelect > -1)
                {
                    if(MessageBox.Show("¿Generar PDF del permiso electrico n° " + numPerSelect + "?", "Consultas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        permisoElect.GenerarPdfPermiso(numPerSelect);
                }
                else
                    throw new Exception("Debe seleccionar un registro del listado para poder imprimirlo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Consultas");
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTipoAforo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var elementoActual = datosAcros.Find(f => f.IdAcron == Convert.ToByte(cboTipoAforo.SelectedValue));
            lblDescTipo.Text = elementoActual.Descripcion;
            CargarDGV(cboTipoAforo.SelectedIndex);
        }

        private void CargarDGV(int indiceCbo)
        {
            switch (indiceCbo)
            {
                case 0: dgvListadoPerCE.DataSource = "";
                    break;
                case 1: dgvListadoPerCE.DataSource = permisosEntregados;
                    break;
            }
        }

        private void CargarControles(int numPermiso)
        {
            //Busco el permiso y su expediente
            var permisoElectrico = permisosElectricos.Find(e => e.NumPermiso == numPermiso);
            var expte = expedientes.Find(f => f.IdExpte == permisoElectrico.Expediente);

            //Controles
            CargarCbos(permisoElectrico.TipoConex, permisoElectrico.TipoMedid, permisoElectrico.TipoObraConex, permisoElectrico.Localidad, permisoElectrico.Inspector);
            txtAnioExp.Texts = expte.Anio;
            txtNumExp.Texts = expte.Numero;
            txtLetraExp.Texts = expte.Letra;
            txtPotencia.Texts = permisoElectrico.PotenciaHP.ToString();
            txtDias.Texts = permisoElectrico.Dias;
            txtIniciador.Texts = permisoElectrico.Iniciador;
            txtDomicilio.Texts = permisoElectrico.Domicilio;
            txtObserv.Texts = permisoElectrico.Observaciones;
            txtComprobante.Texts = permisoElectrico.Comprobante;
            txtImporte.Texts = permisoElectrico.Importe.ToString();
        }

        private void dgvListadoPerCE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                numPerSelect = Convert.ToInt32(dgvListadoPerCE.Rows[e.RowIndex].Cells[0].Value);
                CargarControles(numPerSelect);
            }                
        }

        private void dgvListadoPerCE_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvListadoPerCE.ClearSelection();
        }

        private void txtNumPermiso__TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboTipoAforo.SelectedValue) == 1)
                dgvListadoPerCE.DataSource = "";
            else if (Convert.ToInt32(cboTipoAforo.SelectedValue) == 2)
                dgvListadoPerCE.DataSource = permisosEntregados.FindAll(f => f.NumPermiso.ToString().Contains(txtNumPermiso.Texts));
        }

        private void numeroPuntoComa(int indice, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(".")) || (e.KeyChar == Convert.ToChar(",")))
                if (indice > -1)
                    e.Handled = true;
                else
                    if (e.KeyChar == Convert.ToChar("."))
                    e.KeyChar = Convert.ToChar(",");
                else
                    e.Handled = false;
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

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

        private void txtNumPermiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }
    }
}
