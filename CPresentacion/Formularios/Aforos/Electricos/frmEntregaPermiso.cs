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
using CDominio.ObjetosDeValor;
using CComun.Cache;

namespace CPresentacion.Formularios.Aforos.Electricos
{
    public partial class frmEntregaPermiso : Form
    {
        //Campos
        modTipoConexion tipoCon = new modTipoConexion();
        modTipoMedidor tipoMed = new modTipoMedidor();
        modTipoObraConexionElectrica tipoObCE = new modTipoObraConexionElectrica();
        modLocalidad localidades = new modLocalidad();
        modProfesional inspectores = new modProfesional();  

        public frmEntregaPermiso()
        {
            InitializeComponent();
        }

        private void frmEntregaPermiso_Load(object sender, EventArgs e)
        {
            CargarCbos();
            txtAnioExp.Focus();
        }

        #region Metodos 
        private int NumExpte()
        {
            //Busco si ya existe el expediente a asignar para traer su ID o bien que se agregue el nuevo y me devuelva el ID creado
            modExpediente expte = new modExpediente();          
            expte.Letra = txtLetraExp.Texts.Trim();
            expte.Anio = txtAnioExp.Texts.Trim();
            expte.Numero = txtNumExp.Texts.Trim();
            expte.Iniciador = txtIniciador.Texts.Trim();
            expte.Caratula = "";//Campo opcional para futuro que no hace falta aca
            expte.Activo = true;
            expte.UsuarioCrea = cacUsuario.IdUsuarioAct;
            expte.FechaCrea = DateTime.Now;
            expte.UsuarioModif = cacUsuario.IdUsuarioAct;
            expte.FechaUltModif = DateTime.Now;
            
            return expte.AgregarExpte();
        }

        private void CargarCbos()
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
            var listaInspectores = inspectores.ObtenerInspectores();
            cboInspector.ValueMember = "IdProf";
            cboInspector.DisplayMember = "NombreCompleto";
            cboInspector.DataSource = listaInspectores;
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
        #endregion

        #region Eventos 
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Confirmar nuevo permiso electrico", "Permiso Electrico", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    int valTipoCon = Convert.ToInt32(cboTipoConex.SelectedValue);
                    int valTipoMed = Convert.ToInt32(cboTipoMed.SelectedValue);
                    int valTipoObCE = Convert.ToInt32(cboTipoObraConex.SelectedValue);
                    int valLoc = Convert.ToInt32(cboLocalidad.SelectedValue);
                    int valInspector = Convert.ToInt32(cboInspector.SelectedValue);
                    string valComprobante = txtAnioComp.Texts.Trim() + "-" + txtNumComp.Texts.Trim();

                    modPermisoElectrico permisoCE = new modPermisoElectrico();
                    permisoCE.Acronimo = 2; //Acronimo por defecto para los Permisos Conexion Electrica (PCE)
                    permisoCE.Fecha = DateTime.Today;
                    permisoCE.Expediente = NumExpte();
                    permisoCE.TipoConex = valTipoCon;
                    permisoCE.TipoMedid = valTipoMed;
                    permisoCE.TipoObraConex = valTipoObCE;
                    permisoCE.PotenciaHP = Convert.ToDecimal(txtPotencia.Texts.Trim());
                    permisoCE.Dias = txtDias.Texts.Trim();
                    permisoCE.Iniciador = txtIniciador.Texts.Trim();
                    permisoCE.Domicilio = txtDomicilio.Texts.Trim();
                    permisoCE.Localidad = valLoc;
                    permisoCE.Inspector = valInspector;
                    permisoCE.Observaciones = txtObserv.Texts.Trim();
                    permisoCE.Comprobante = valComprobante;
                    permisoCE.Importe = Convert.ToDecimal(txtImporte.Texts.Trim());
                    permisoCE.UsuarioCrea = cacUsuario.IdUsuarioAct;
                    permisoCE.FechaCrea = DateTime.Now;
                    permisoCE.UsuarioModif = cacUsuario.IdUsuarioAct;
                    permisoCE.FechaUltModif = DateTime.Now;
                    permisoCE.estado = EstadoEntidad.Agregar;

                    string resultado = permisoCE.GuardarCambios();
                    MessageBox.Show(resultado, "Permiso Electrico");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Permiso Electrico");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("¿Limpiar todos los campos del formulario?", "Limpiar Controles", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                txtAnioExp.Texts = "";
                txtNumExp.Texts = "";
                txtLetraExp.Texts = "";
                cboTipoConex.SelectedIndex = 0;
                cboTipoMed.SelectedIndex = 0;
                cboTipoObraConex.SelectedIndex = 0;
                txtPotencia.Texts = "0,00";
                txtDias.Texts = "-";
                txtIniciador.Texts = "";
                txtDomicilio.Texts = "";
                cboLocalidad.SelectedIndex = 0;
                cboInspector.SelectedIndex = 0;
                txtObserv.Texts = "";
                txtAnioComp.Texts = "";
                txtNumComp.Texts = "";
                txtImporte.Texts = "0,00";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPotencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeroPuntoComa(txtPotencia.Texts.IndexOf(","), e);
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeroPuntoComa(txtImporte.Texts.IndexOf(","), e);
        }

        private void txtAnioExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void txtNumExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void txtLetraExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void txtIniciador_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtAnioComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void txtNumComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
        }

        private void txtAnioExp__TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txtAnioExp.Texts = txt.Text.TrimStart(Convert.ToChar("0"));
        }        

        private void txtNumExp__TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txtNumExp.Texts = txt.Text.TrimStart(Convert.ToChar("0"));
        }

        private void txtDias__TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txtDias.Texts = txt.Text.TrimStart(Convert.ToChar("0"));
        }

        private void txtAnioComp__TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txtAnioComp.Texts = txt.Text.TrimStart(Convert.ToChar("0"));
        }

        private void txtNumComp__TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txtNumComp.Texts = txt.Text.TrimStart(Convert.ToChar("0"));
        }

        private void txtLetraExp_Leave(object sender, EventArgs e)
        {
            txtLetraExp.Texts = txtLetraExp.Texts.ToUpper();
        }

        private void txtIniciador_Leave(object sender, EventArgs e)
        {
            txtIniciador.Texts = txtIniciador.Texts.ToUpper();
        }

        private void txtDomicilio_Leave(object sender, EventArgs e)
        {
            txtDomicilio.Texts = txtDomicilio.Texts.ToUpper();
        }

        private void txtObserv_Leave(object sender, EventArgs e)
        {
            txtObserv.Texts = txtObserv.Texts.ToUpper();
        }

        private void txtPotencia_Leave(object sender, EventArgs e)
        {
            if (txtPotencia.Texts != null && txtPotencia.Texts != "")
            {
                var valor = Convert.ToDecimal(txtPotencia.Texts);
                txtPotencia.Texts = valor.ToString("F2");
            }
            else
                txtPotencia.Texts = "0,00";
        }

        private void txtDias_Leave(object sender, EventArgs e)
        {
            if (txtDias.Texts == null || txtDias.Texts == "")
                txtDias.Texts = "-";
        }

        private void txtImporte_Leave(object sender, EventArgs e)
        {
            if (txtImporte.Texts != null && txtImporte.Texts != "")
            {
                var valor = Convert.ToDecimal(txtImporte.Texts);
                txtImporte.Texts = valor.ToString("F2");
            }
            else
                txtImporte.Texts = "0,00";
        }
        #endregion
    }
}
