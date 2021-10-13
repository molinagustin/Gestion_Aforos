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
        }

        private void CargarCbos()
        {
            //Tipos Conexiones -> Filtro per medio de FindAll para que el modTipoConexiones sea del Id 2 o 4
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Confirmar nuevo permiso electrico", "Permiso Electrico", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                int valTipoCon = cboTipoConex.SelectedIndex + 1;
                int valTipoMed = cboTipoMed.SelectedIndex + 1;
                int valTipoObCE = cboTipoObraConex.SelectedIndex + 1;
                int valLoc = cboLocalidad.SelectedIndex + 1;
                int valInspector = cboInspector.SelectedIndex + 1;
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
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("¿Limpiar todos los campos del formulario?", "Limpiar Controles", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
        
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
    }
}
