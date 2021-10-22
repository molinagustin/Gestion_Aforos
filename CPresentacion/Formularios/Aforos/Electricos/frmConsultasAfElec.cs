using CComun.Cache;
using CDominio.Modelos;
using CDominio.ObjetosDeValor;
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
        #region Campos
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
        #endregion

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

        #region Metodos
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

        private void CargarDGV(int indiceCbo)
        {
            switch (indiceCbo)
            {
                case 0:
                    dgvListadoPerCE.DataSource = "";
                    break;
                case 1:
                    dgvListadoPerCE.DataSource = permisosEntregados;
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

        private void HabilitarControles()
        {
            Controles(true);
        }

        private void Controles(bool activo)
        {
            if (cacUsuario.Privilegio == 1)
            {
                txtAnioExp.Enabled = activo;
                txtNumExp.Enabled = activo;
                txtLetraExp.Enabled = activo;
            }
            
            cboTipoConex.Enabled = activo;
            cboTipoMed.Enabled = activo;
            cboTipoObraConex.Enabled = activo;
            txtPotencia.Enabled = activo;
            txtDias.Enabled = activo;
            txtIniciador.Enabled = activo;
            txtDomicilio.Enabled = activo;
            cboLocalidad.Enabled = activo;
            cboInspector.Enabled = activo;
            txtObserv.Enabled = activo;
            txtComprobante.Enabled = activo;
            txtImporte.Enabled = activo;
        }

        private void DeshabilitarControles()
        {
            CargarControles(numPerSelect);
            Controles(false);
        }

        private void HabilitarBotonesModif(bool btnPrimeros, bool btnSegundos)
        {
            btnModificar.Enabled = btnPrimeros;
            btnModificar.Visible = btnPrimeros;
            btnCancelar.Enabled = btnPrimeros;
            btnCancelar.Visible = btnPrimeros;
            dgvListadoPerCE.Enabled = btnPrimeros;
            cboTipoAforo.Enabled = btnPrimeros;
            txtNumPermiso.Enabled = btnPrimeros;
            btnImprimir.Enabled = btnPrimeros;

            btnGuardar.Enabled = btnSegundos;
            btnGuardar.Visible = btnSegundos;
            btnCancelModif.Enabled = btnSegundos;
            btnCancelModif.Visible = btnSegundos;
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

        private void AsignarDatosPCE(ref modPermisoElectrico permiso, int numExpte)
        {
            permiso.Fecha = DateTime.Today;
            permiso.Expediente = numExpte;
            permiso.TipoConex = Convert.ToInt32(cboTipoConex.SelectedValue);
            permiso.TipoMedid = Convert.ToInt32(cboTipoMed.SelectedValue);
            permiso.TipoObraConex = Convert.ToInt32(cboTipoObraConex.SelectedValue);
            permiso.PotenciaHP = Convert.ToDecimal(txtPotencia.Texts.Trim());
            permiso.Dias = txtDias.Texts.Trim();
            permiso.Iniciador = txtIniciador.Texts.Trim();
            permiso.Domicilio = txtDomicilio.Texts.Trim();
            permiso.Localidad = Convert.ToInt32(cboLocalidad.SelectedValue);
            permiso.Inspector = Convert.ToInt32(cboInspector.SelectedValue);
            permiso.Observaciones = txtObserv.Texts.Trim();
            permiso.Comprobante = txtComprobante.Texts.Trim();
            permiso.Importe = Convert.ToDecimal(txtImporte.Texts.Trim());
            permiso.UsuarioModif = cacUsuario.IdUsuarioAct;
            permiso.FechaUltModif = DateTime.Now;
            permiso.estado = EstadoEntidad.Modificar;
        }
        #endregion

        #region Eventos 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Modificar el permiso nº " + numPerSelect + "? Quedará registrada la modificación.", "Consultas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Busco el permiso y su expediente
                    var permisoElectrico = permisosElectricos.Find(g => g.NumPermiso == numPerSelect);
                    var expte = expedientes.Find(f => f.IdExpte == permisoElectrico.Expediente);

                    if (cacUsuario.Privilegio == 1)
                    {
                        //Busco en la lista de expedientes si ya hay uno creado con el año y numero del expediente colocado en los controles
                        var expteExistente = expedientes.Find(x => x.Numero == txtNumExp.Texts && x.Anio == txtAnioExp.Texts);
                        if (expteExistente != null && expteExistente.IdExpte > 0)
                        {
                            //Guardo pocos datos del expediente ya que ya existe el numero solicitado
                            expteExistente.Letra = txtLetraExp.Texts.Trim();
                            expteExistente.UsuarioModif = cacUsuario.IdUsuarioAct;
                            expteExistente.FechaUltModif = DateTime.Now;
                            expteExistente.estado = EstadoEntidad.Modificar;

                            //Guardo Datos del PCE y le cambio el numero de ID de referencia al expediente existente
                            AsignarDatosPCE(ref permisoElectrico, expteExistente.IdExpte);
                            
                            if (expteExistente.GuardarCambios() > 0)
                            {
                                int resultado = permisoElectrico.GuardarCambios();
                                if (resultado > 0)
                                {
                                    //Deshabilito los controles y vuelvo a cargar los registros actualizados en el DGV
                                    DeshabilitarControles();
                                    HabilitarBotonesModif(true, false);
                                    permisosEntregados = permisosCEEnt.ObtenerPermisosElect();
                                    CargarDGV(cboTipoAforo.SelectedIndex);
                                    txtNumPermiso.Texts = numPerSelect.ToString();
                                    numPerSelect = -1;
                                    MessageBox.Show("El permiso electrico n° " + resultado + " fue actualizado correctamente.", "Consultas");
                                }
                                else
                                    throw new Exception("No se pudo actualizar el permiso electrico n° " + permisoElectrico.NumPermiso);
                            }
                            else
                                throw new Exception("No se pudo actualizar el expediente, verifique los campos completados.");
                        } 
                        else
                        {                            
                            //Guardo Datos del Expediente cuyo numero y año no existe en la base de datos
                            expte.Letra = txtLetraExp.Texts.Trim();
                            expte.Anio = txtAnioExp.Texts;
                            expte.Numero = txtNumExp.Texts;
                            expte.UsuarioModif = cacUsuario.IdUsuarioAct;
                            expte.FechaUltModif = DateTime.Now;
                            expte.estado = EstadoEntidad.Modificar;

                            //Guardo Datos del PCE
                            AsignarDatosPCE(ref permisoElectrico, expte.IdExpte);
                           
                            if (expte.GuardarCambios() > 0)
                            {
                                int resultado = permisoElectrico.GuardarCambios();
                                if (resultado > 0)
                                {
                                    //Deshabilito los controles y vuelvo a cargar los registros actualizados en el DGV
                                    DeshabilitarControles();
                                    HabilitarBotonesModif(true, false);
                                    permisosEntregados = permisosCEEnt.ObtenerPermisosElect();
                                    CargarDGV(cboTipoAforo.SelectedIndex);
                                    txtNumPermiso.Texts = numPerSelect.ToString();
                                    numPerSelect = -1;
                                    MessageBox.Show("El permiso electrico n° " + resultado + " fue actualizado correctamente.", "Consultas");
                                }
                                else
                                    throw new Exception("No se pudo actualizar el permiso electrico n° " + permisoElectrico.NumPermiso);
                            }
                            else
                                throw new Exception("No se pudo actualizar el expediente, verifique los campos completados.");
                        }
                    }
                    else
                    {
                        //Guardo Datos del PCE
                        AsignarDatosPCE(ref permisoElectrico, expte.IdExpte);
                        
                        int resultado = permisoElectrico.GuardarCambios();
                        if (resultado > 0)
                        {
                            //Deshabilito los controles y vuelvo a cargar los registros actualizados en el DGV
                            DeshabilitarControles();
                            HabilitarBotonesModif(true, false);
                            permisosEntregados = permisosCEEnt.ObtenerPermisosElect();
                            CargarDGV(cboTipoAforo.SelectedIndex);
                            txtNumPermiso.Texts = numPerSelect.ToString();
                            numPerSelect = -1;
                            MessageBox.Show("El permiso electrico n° " + resultado + " fue actualizado correctamente.", "Consultas");
                        }
                        else
                            throw new Exception("No se pudo actualizar el permiso electrico n° " + permisoElectrico.NumPermiso);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Consultas");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (numPerSelect > -1)
                {
                    HabilitarControles();
                    HabilitarBotonesModif(false, true);
                }
                else
                    throw new Exception("Debe seleccionar un registro del listado si quiere modificarlo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Consultas");
            }
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

        private void btnCancelModif_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cancelar la modificacion?", "Consultas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeshabilitarControles();
                HabilitarBotonesModif(true, false);
            }
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

        private void cboTipoAforo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var elementoActual = datosAcros.Find(f => f.IdAcron == Convert.ToByte(cboTipoAforo.SelectedValue));
            lblDescTipo.Text = elementoActual.Descripcion;
            CargarDGV(cboTipoAforo.SelectedIndex);
            numPerSelect = -1;
        }
             
        private void txtNumPermiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(e);
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

        private void txtNumPermiso__TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboTipoAforo.SelectedValue) == 1)
                dgvListadoPerCE.DataSource = "";
            else if (Convert.ToInt32(cboTipoAforo.SelectedValue) == 2)
                dgvListadoPerCE.DataSource = permisosEntregados.FindAll(f => f.NumPermiso.ToString().Contains(txtNumPermiso.Texts));

            //Reestablezco el permiso para que se vuelva a seleccionar de la busqueda
            numPerSelect = -1;
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
                txtDias.Texts = "---";
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
