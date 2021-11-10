
namespace CPresentacion.Formularios.Aforos.Electricos
{
    partial class frmConsultasAfElec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListadoPerCE = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescTipo = new System.Windows.Forms.Label();
            this.lblNumPermiso = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblObserv = new System.Windows.Forms.Label();
            this.lblInspec = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblDom = new System.Windows.Forms.Label();
            this.lblIniciador = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.lblTipoOb = new System.Windows.Forms.Label();
            this.lblTipoMed = new System.Windows.Forms.Label();
            this.lblTipoCon = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblLetraExp = new System.Windows.Forms.Label();
            this.lblNumExp = new System.Windows.Forms.Label();
            this.lblAnioExp = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.btnCancelModif = new CPresentacion.ControlesPersonalizados.CButton();
            this.btnGuardar = new CPresentacion.ControlesPersonalizados.CButton();
            this.txtImporte = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtComprobante = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtObserv = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.cboInspector = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.cboLocalidad = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.txtDomicilio = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtIniciador = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtDias = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtPotencia = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.cboTipoObraConex = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.cboTipoMed = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.cboTipoConex = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.txtLetraExp = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtNumExp = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtAnioExp = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.btnModificar = new CPresentacion.ControlesPersonalizados.CButton();
            this.btnImprimir = new CPresentacion.ControlesPersonalizados.CButton();
            this.txtNumPermiso = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.cboTipoAforo = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.btnCancelar = new CPresentacion.ControlesPersonalizados.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPerCE)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoPerCE
            // 
            this.dgvListadoPerCE.AllowUserToAddRows = false;
            this.dgvListadoPerCE.AllowUserToDeleteRows = false;
            this.dgvListadoPerCE.AllowUserToResizeRows = false;
            this.dgvListadoPerCE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoPerCE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoPerCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPerCE.Location = new System.Drawing.Point(12, 152);
            this.dgvListadoPerCE.MultiSelect = false;
            this.dgvListadoPerCE.Name = "dgvListadoPerCE";
            this.dgvListadoPerCE.ReadOnly = true;
            this.dgvListadoPerCE.RowHeadersVisible = false;
            this.dgvListadoPerCE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPerCE.Size = new System.Drawing.Size(281, 508);
            this.dgvListadoPerCE.TabIndex = 21;
            this.dgvListadoPerCE.TabStop = false;
            this.dgvListadoPerCE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoPerCE_CellClick);
            this.dgvListadoPerCE.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvListadoPerCE_DataBindingComplete);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(5, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(907, 45);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "CONSULTAS AFOROS ELECTRICOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(12, 76);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(72, 21);
            this.lblBuscar.TabIndex = 23;
            this.lblBuscar.Text = "BUSCAR";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTipo.Location = new System.Drawing.Point(90, 76);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 21);
            this.lblTipo.TabIndex = 24;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescTipo
            // 
            this.lblDescTipo.AutoSize = true;
            this.lblDescTipo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescTipo.Location = new System.Drawing.Point(294, 76);
            this.lblDescTipo.Name = "lblDescTipo";
            this.lblDescTipo.Size = new System.Drawing.Size(91, 21);
            this.lblDescTipo.TabIndex = 26;
            this.lblDescTipo.Text = "Descripcion";
            this.lblDescTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumPermiso
            // 
            this.lblNumPermiso.AutoSize = true;
            this.lblNumPermiso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNumPermiso.Location = new System.Drawing.Point(90, 118);
            this.lblNumPermiso.Name = "lblNumPermiso";
            this.lblNumPermiso.Size = new System.Drawing.Size(68, 21);
            this.lblNumPermiso.TabIndex = 28;
            this.lblNumPermiso.Text = "Numero";
            this.lblNumPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComp
            // 
            this.lblComp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblComp.Location = new System.Drawing.Point(333, 626);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(96, 15);
            this.lblComp.TabIndex = 41;
            this.lblComp.Text = "COMPROBANTE";
            this.lblComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObserv
            // 
            this.lblObserv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObserv.AutoSize = true;
            this.lblObserv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblObserv.Location = new System.Drawing.Point(333, 576);
            this.lblObserv.Name = "lblObserv";
            this.lblObserv.Size = new System.Drawing.Size(102, 15);
            this.lblObserv.TabIndex = 40;
            this.lblObserv.Text = "OBSERVACIONES";
            this.lblObserv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInspec
            // 
            this.lblInspec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInspec.AutoSize = true;
            this.lblInspec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInspec.Location = new System.Drawing.Point(333, 526);
            this.lblInspec.Name = "lblInspec";
            this.lblInspec.Size = new System.Drawing.Size(71, 15);
            this.lblInspec.TabIndex = 39;
            this.lblInspec.Text = "INSPECTOR";
            this.lblInspec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoc
            // 
            this.lblLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoc.Location = new System.Drawing.Point(333, 476);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(73, 15);
            this.lblLoc.TabIndex = 38;
            this.lblLoc.Text = "LOCALIDAD";
            this.lblLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDom
            // 
            this.lblDom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDom.AutoSize = true;
            this.lblDom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDom.Location = new System.Drawing.Point(333, 426);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(70, 15);
            this.lblDom.TabIndex = 37;
            this.lblDom.Text = "DOMICILIO";
            this.lblDom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIniciador
            // 
            this.lblIniciador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIniciador.AutoSize = true;
            this.lblIniciador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIniciador.Location = new System.Drawing.Point(333, 376);
            this.lblIniciador.Name = "lblIniciador";
            this.lblIniciador.Size = new System.Drawing.Size(69, 15);
            this.lblIniciador.TabIndex = 36;
            this.lblIniciador.Text = "INICIADOR";
            this.lblIniciador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPotencia
            // 
            this.lblPotencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPotencia.Location = new System.Drawing.Point(333, 326);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(91, 15);
            this.lblPotencia.TabIndex = 35;
            this.lblPotencia.Text = "POTENCIA (HP)";
            this.lblPotencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoOb
            // 
            this.lblTipoOb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoOb.AutoSize = true;
            this.lblTipoOb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoOb.Location = new System.Drawing.Point(333, 276);
            this.lblTipoOb.Name = "lblTipoOb";
            this.lblTipoOb.Size = new System.Drawing.Size(112, 15);
            this.lblTipoOb.TabIndex = 34;
            this.lblTipoOb.Text = "TIPO OBRA CONEX";
            this.lblTipoOb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoMed
            // 
            this.lblTipoMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoMed.AutoSize = true;
            this.lblTipoMed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoMed.Location = new System.Drawing.Point(333, 226);
            this.lblTipoMed.Name = "lblTipoMed";
            this.lblTipoMed.Size = new System.Drawing.Size(93, 15);
            this.lblTipoMed.TabIndex = 33;
            this.lblTipoMed.Text = "TIPO MEDIDOR";
            this.lblTipoMed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoCon
            // 
            this.lblTipoCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoCon.AutoSize = true;
            this.lblTipoCon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoCon.Location = new System.Drawing.Point(333, 176);
            this.lblTipoCon.Name = "lblTipoCon";
            this.lblTipoCon.Size = new System.Drawing.Size(98, 15);
            this.lblTipoCon.TabIndex = 32;
            this.lblTipoCon.Text = "TIPO CONEXION";
            this.lblTipoCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExp
            // 
            this.lblExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExp.Location = new System.Drawing.Point(333, 126);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(75, 15);
            this.lblExp.TabIndex = 31;
            this.lblExp.Text = "EXPEDIENTE";
            this.lblExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLetraExp
            // 
            this.lblLetraExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetraExp.AutoSize = true;
            this.lblLetraExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLetraExp.Location = new System.Drawing.Point(784, 126);
            this.lblLetraExp.Name = "lblLetraExp";
            this.lblLetraExp.Size = new System.Drawing.Size(33, 15);
            this.lblLetraExp.TabIndex = 47;
            this.lblLetraExp.Text = "Letra";
            this.lblLetraExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumExp
            // 
            this.lblNumExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumExp.AutoSize = true;
            this.lblNumExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumExp.Location = new System.Drawing.Point(590, 126);
            this.lblNumExp.Name = "lblNumExp";
            this.lblNumExp.Size = new System.Drawing.Size(21, 15);
            this.lblNumExp.TabIndex = 46;
            this.lblNumExp.Text = "Nº";
            this.lblNumExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnioExp
            // 
            this.lblAnioExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnioExp.AutoSize = true;
            this.lblAnioExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAnioExp.Location = new System.Drawing.Point(455, 126);
            this.lblAnioExp.Name = "lblAnioExp";
            this.lblAnioExp.Size = new System.Drawing.Size(29, 15);
            this.lblAnioExp.TabIndex = 45;
            this.lblAnioExp.Text = "Año";
            this.lblAnioExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDias
            // 
            this.lblDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDias.Location = new System.Drawing.Point(666, 326);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(29, 15);
            this.lblDias.TabIndex = 55;
            this.lblDias.Text = "Dias";
            this.lblDias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImporte
            // 
            this.lblImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblImporte.Location = new System.Drawing.Point(721, 626);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(49, 15);
            this.lblImporte.TabIndex = 61;
            this.lblImporte.Text = "Importe";
            this.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelModif
            // 
            this.btnCancelModif.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnCancelModif.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnCancelModif.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelModif.BorderRadius = 8;
            this.btnCancelModif.BorderSize = 0;
            this.btnCancelModif.Enabled = false;
            this.btnCancelModif.FlatAppearance.BorderSize = 0;
            this.btnCancelModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelModif.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelModif.ForeColor = System.Drawing.Color.White;
            this.btnCancelModif.Location = new System.Drawing.Point(593, 666);
            this.btnCancelModif.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnCancelModif.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnCancelModif.Name = "btnCancelModif";
            this.btnCancelModif.Size = new System.Drawing.Size(130, 40);
            this.btnCancelModif.TabIndex = 63;
            this.btnCancelModif.Text = "CANCELAR";
            this.btnCancelModif.TextColor = System.Drawing.Color.White;
            this.btnCancelModif.UseVisualStyleBackColor = false;
            this.btnCancelModif.Visible = false;
            this.btnCancelModif.Click += new System.EventHandler(this.btnCancelModif_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 8;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(231, 666);
            this.btnGuardar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnGuardar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 40);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporte.BackColor = System.Drawing.SystemColors.Window;
            this.txtImporte.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtImporte.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtImporte.BorderRadius = 8;
            this.txtImporte.BorderSize = 1;
            this.txtImporte.Enabled = false;
            this.txtImporte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtImporte.ForeColor = System.Drawing.Color.DimGray;
            this.txtImporte.Location = new System.Drawing.Point(792, 618);
            this.txtImporte.MaxLength = 8;
            this.txtImporte.Multiline = false;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtImporte.PasswordChar = false;
            this.txtImporte.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtImporte.PlaceholderText = "";
            this.txtImporte.Size = new System.Drawing.Size(105, 30);
            this.txtImporte.TabIndex = 60;
            this.txtImporte.Texts = "0,00";
            this.txtImporte.UnderlinedStyle = false;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtImporte.Leave += new System.EventHandler(this.txtImporte_Leave);
            // 
            // txtComprobante
            // 
            this.txtComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComprobante.BackColor = System.Drawing.SystemColors.Window;
            this.txtComprobante.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtComprobante.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtComprobante.BorderRadius = 8;
            this.txtComprobante.BorderSize = 1;
            this.txtComprobante.Enabled = false;
            this.txtComprobante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComprobante.ForeColor = System.Drawing.Color.DimGray;
            this.txtComprobante.Location = new System.Drawing.Point(499, 618);
            this.txtComprobante.MaxLength = 16;
            this.txtComprobante.Multiline = false;
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtComprobante.PasswordChar = false;
            this.txtComprobante.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtComprobante.PlaceholderText = "";
            this.txtComprobante.Size = new System.Drawing.Size(200, 30);
            this.txtComprobante.TabIndex = 59;
            this.txtComprobante.Texts = "";
            this.txtComprobante.UnderlinedStyle = false;
            // 
            // txtObserv
            // 
            this.txtObserv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObserv.BackColor = System.Drawing.SystemColors.Window;
            this.txtObserv.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtObserv.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtObserv.BorderRadius = 8;
            this.txtObserv.BorderSize = 1;
            this.txtObserv.Enabled = false;
            this.txtObserv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObserv.ForeColor = System.Drawing.Color.DimGray;
            this.txtObserv.Location = new System.Drawing.Point(499, 568);
            this.txtObserv.MaxLength = 200;
            this.txtObserv.Multiline = false;
            this.txtObserv.Name = "txtObserv";
            this.txtObserv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtObserv.PasswordChar = false;
            this.txtObserv.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObserv.PlaceholderText = "";
            this.txtObserv.Size = new System.Drawing.Size(402, 30);
            this.txtObserv.TabIndex = 58;
            this.txtObserv.Texts = "";
            this.txtObserv.UnderlinedStyle = false;
            this.txtObserv.Leave += new System.EventHandler(this.txtObserv_Leave);
            // 
            // cboInspector
            // 
            this.cboInspector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboInspector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboInspector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboInspector.BackColor = System.Drawing.SystemColors.Window;
            this.cboInspector.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboInspector.BorderSize = 1;
            this.cboInspector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboInspector.Enabled = false;
            this.cboInspector.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboInspector.ForeColor = System.Drawing.Color.DimGray;
            this.cboInspector.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboInspector.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboInspector.ListTextColor = System.Drawing.Color.DimGray;
            this.cboInspector.Location = new System.Drawing.Point(499, 518);
            this.cboInspector.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboInspector.Name = "cboInspector";
            this.cboInspector.Padding = new System.Windows.Forms.Padding(1);
            this.cboInspector.Size = new System.Drawing.Size(307, 30);
            this.cboInspector.TabIndex = 57;
            this.cboInspector.Texts = "";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLocalidad.BackColor = System.Drawing.SystemColors.Window;
            this.cboLocalidad.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLocalidad.BorderSize = 1;
            this.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalidad.Enabled = false;
            this.cboLocalidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLocalidad.ForeColor = System.Drawing.Color.DimGray;
            this.cboLocalidad.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLocalidad.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLocalidad.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLocalidad.Location = new System.Drawing.Point(499, 468);
            this.cboLocalidad.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Padding = new System.Windows.Forms.Padding(1);
            this.cboLocalidad.Size = new System.Drawing.Size(240, 30);
            this.cboLocalidad.TabIndex = 56;
            this.cboLocalidad.Texts = "";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomicilio.BackColor = System.Drawing.SystemColors.Window;
            this.txtDomicilio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDomicilio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDomicilio.BorderRadius = 8;
            this.txtDomicilio.BorderSize = 1;
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDomicilio.ForeColor = System.Drawing.Color.DimGray;
            this.txtDomicilio.Location = new System.Drawing.Point(499, 418);
            this.txtDomicilio.MaxLength = 120;
            this.txtDomicilio.Multiline = false;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDomicilio.PasswordChar = false;
            this.txtDomicilio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDomicilio.PlaceholderText = "";
            this.txtDomicilio.Size = new System.Drawing.Size(402, 30);
            this.txtDomicilio.TabIndex = 54;
            this.txtDomicilio.Texts = "";
            this.txtDomicilio.UnderlinedStyle = false;
            this.txtDomicilio.Leave += new System.EventHandler(this.txtDomicilio_Leave);
            // 
            // txtIniciador
            // 
            this.txtIniciador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIniciador.BackColor = System.Drawing.SystemColors.Window;
            this.txtIniciador.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIniciador.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIniciador.BorderRadius = 8;
            this.txtIniciador.BorderSize = 1;
            this.txtIniciador.Enabled = false;
            this.txtIniciador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIniciador.ForeColor = System.Drawing.Color.DimGray;
            this.txtIniciador.Location = new System.Drawing.Point(499, 368);
            this.txtIniciador.MaxLength = 100;
            this.txtIniciador.Multiline = false;
            this.txtIniciador.Name = "txtIniciador";
            this.txtIniciador.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIniciador.PasswordChar = false;
            this.txtIniciador.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIniciador.PlaceholderText = "";
            this.txtIniciador.Size = new System.Drawing.Size(402, 30);
            this.txtIniciador.TabIndex = 53;
            this.txtIniciador.Texts = "";
            this.txtIniciador.UnderlinedStyle = false;
            this.txtIniciador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIniciador_KeyPress);
            this.txtIniciador.Leave += new System.EventHandler(this.txtIniciador_Leave);
            // 
            // txtDias
            // 
            this.txtDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDias.BackColor = System.Drawing.SystemColors.Window;
            this.txtDias.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDias.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDias.BorderRadius = 8;
            this.txtDias.BorderSize = 1;
            this.txtDias.Enabled = false;
            this.txtDias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDias.ForeColor = System.Drawing.Color.DimGray;
            this.txtDias.Location = new System.Drawing.Point(712, 318);
            this.txtDias.MaxLength = 3;
            this.txtDias.Multiline = false;
            this.txtDias.Name = "txtDias";
            this.txtDias.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDias.PasswordChar = false;
            this.txtDias.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDias.PlaceholderText = "";
            this.txtDias.Size = new System.Drawing.Size(94, 30);
            this.txtDias.TabIndex = 52;
            this.txtDias.Texts = "---";
            this.txtDias.UnderlinedStyle = false;
            this.txtDias._TextChanged += new System.EventHandler(this.txtDias__TextChanged);
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            this.txtDias.Leave += new System.EventHandler(this.txtDias_Leave);
            // 
            // txtPotencia
            // 
            this.txtPotencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPotencia.BackColor = System.Drawing.SystemColors.Window;
            this.txtPotencia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPotencia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPotencia.BorderRadius = 8;
            this.txtPotencia.BorderSize = 1;
            this.txtPotencia.Enabled = false;
            this.txtPotencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPotencia.ForeColor = System.Drawing.Color.DimGray;
            this.txtPotencia.Location = new System.Drawing.Point(499, 318);
            this.txtPotencia.MaxLength = 6;
            this.txtPotencia.Multiline = false;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPotencia.PasswordChar = false;
            this.txtPotencia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPotencia.PlaceholderText = "";
            this.txtPotencia.Size = new System.Drawing.Size(120, 30);
            this.txtPotencia.TabIndex = 51;
            this.txtPotencia.Tag = "";
            this.txtPotencia.Texts = "0,00";
            this.txtPotencia.UnderlinedStyle = false;
            this.txtPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPotencia_KeyPress);
            this.txtPotencia.Leave += new System.EventHandler(this.txtPotencia_Leave);
            // 
            // cboTipoObraConex
            // 
            this.cboTipoObraConex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoObraConex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTipoObraConex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoObraConex.BackColor = System.Drawing.SystemColors.Window;
            this.cboTipoObraConex.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoObraConex.BorderSize = 1;
            this.cboTipoObraConex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTipoObraConex.Enabled = false;
            this.cboTipoObraConex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTipoObraConex.ForeColor = System.Drawing.Color.DimGray;
            this.cboTipoObraConex.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoObraConex.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTipoObraConex.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTipoObraConex.Location = new System.Drawing.Point(499, 268);
            this.cboTipoObraConex.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTipoObraConex.Name = "cboTipoObraConex";
            this.cboTipoObraConex.Padding = new System.Windows.Forms.Padding(1);
            this.cboTipoObraConex.Size = new System.Drawing.Size(402, 30);
            this.cboTipoObraConex.TabIndex = 50;
            this.cboTipoObraConex.Texts = "";
            // 
            // cboTipoMed
            // 
            this.cboTipoMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoMed.BackColor = System.Drawing.SystemColors.Window;
            this.cboTipoMed.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoMed.BorderSize = 1;
            this.cboTipoMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMed.Enabled = false;
            this.cboTipoMed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTipoMed.ForeColor = System.Drawing.Color.DimGray;
            this.cboTipoMed.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoMed.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTipoMed.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTipoMed.Location = new System.Drawing.Point(499, 218);
            this.cboTipoMed.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTipoMed.Name = "cboTipoMed";
            this.cboTipoMed.Padding = new System.Windows.Forms.Padding(1);
            this.cboTipoMed.Size = new System.Drawing.Size(200, 30);
            this.cboTipoMed.TabIndex = 49;
            this.cboTipoMed.Texts = "";
            // 
            // cboTipoConex
            // 
            this.cboTipoConex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoConex.BackColor = System.Drawing.SystemColors.Window;
            this.cboTipoConex.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoConex.BorderSize = 1;
            this.cboTipoConex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConex.Enabled = false;
            this.cboTipoConex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTipoConex.ForeColor = System.Drawing.Color.DimGray;
            this.cboTipoConex.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoConex.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTipoConex.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTipoConex.Location = new System.Drawing.Point(499, 168);
            this.cboTipoConex.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTipoConex.Name = "cboTipoConex";
            this.cboTipoConex.Padding = new System.Windows.Forms.Padding(1);
            this.cboTipoConex.Size = new System.Drawing.Size(200, 30);
            this.cboTipoConex.TabIndex = 48;
            this.cboTipoConex.Texts = "";
            // 
            // txtLetraExp
            // 
            this.txtLetraExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLetraExp.BackColor = System.Drawing.SystemColors.Window;
            this.txtLetraExp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLetraExp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLetraExp.BorderRadius = 8;
            this.txtLetraExp.BorderSize = 1;
            this.txtLetraExp.Enabled = false;
            this.txtLetraExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLetraExp.ForeColor = System.Drawing.Color.DimGray;
            this.txtLetraExp.Location = new System.Drawing.Point(835, 118);
            this.txtLetraExp.MaxLength = 3;
            this.txtLetraExp.Multiline = false;
            this.txtLetraExp.Name = "txtLetraExp";
            this.txtLetraExp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLetraExp.PasswordChar = false;
            this.txtLetraExp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLetraExp.PlaceholderText = "";
            this.txtLetraExp.Size = new System.Drawing.Size(66, 30);
            this.txtLetraExp.TabIndex = 44;
            this.txtLetraExp.Texts = "";
            this.txtLetraExp.UnderlinedStyle = false;
            this.txtLetraExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetraExp_KeyPress);
            this.txtLetraExp.Leave += new System.EventHandler(this.txtLetraExp_Leave);
            // 
            // txtNumExp
            // 
            this.txtNumExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumExp.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumExp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumExp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumExp.BorderRadius = 8;
            this.txtNumExp.BorderSize = 1;
            this.txtNumExp.Enabled = false;
            this.txtNumExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumExp.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumExp.Location = new System.Drawing.Point(625, 118);
            this.txtNumExp.MaxLength = 10;
            this.txtNumExp.Multiline = false;
            this.txtNumExp.Name = "txtNumExp";
            this.txtNumExp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumExp.PasswordChar = false;
            this.txtNumExp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumExp.PlaceholderText = "";
            this.txtNumExp.Size = new System.Drawing.Size(129, 30);
            this.txtNumExp.TabIndex = 43;
            this.txtNumExp.Texts = "";
            this.txtNumExp.UnderlinedStyle = false;
            this.txtNumExp._TextChanged += new System.EventHandler(this.txtNumExp__TextChanged);
            this.txtNumExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumExp_KeyPress);
            // 
            // txtAnioExp
            // 
            this.txtAnioExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnioExp.BackColor = System.Drawing.SystemColors.Window;
            this.txtAnioExp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAnioExp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAnioExp.BorderRadius = 8;
            this.txtAnioExp.BorderSize = 1;
            this.txtAnioExp.Enabled = false;
            this.txtAnioExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAnioExp.ForeColor = System.Drawing.Color.DimGray;
            this.txtAnioExp.Location = new System.Drawing.Point(499, 118);
            this.txtAnioExp.MaxLength = 4;
            this.txtAnioExp.Multiline = false;
            this.txtAnioExp.Name = "txtAnioExp";
            this.txtAnioExp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAnioExp.PasswordChar = false;
            this.txtAnioExp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAnioExp.PlaceholderText = "";
            this.txtAnioExp.Size = new System.Drawing.Size(70, 30);
            this.txtAnioExp.TabIndex = 42;
            this.txtAnioExp.Texts = "";
            this.txtAnioExp.UnderlinedStyle = false;
            this.txtAnioExp._TextChanged += new System.EventHandler(this.txtAnioExp__TextChanged);
            this.txtAnioExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnioExp_KeyPress);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModificar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 8;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(231, 666);
            this.btnModificar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnModificar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 40);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.btnImprimir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.btnImprimir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnImprimir.BorderRadius = 8;
            this.btnImprimir.BorderSize = 0;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(412, 666);
            this.btnImprimir.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnImprimir.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(130, 40);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextColor = System.Drawing.Color.White;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtNumPermiso
            // 
            this.txtNumPermiso.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumPermiso.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumPermiso.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumPermiso.BorderRadius = 8;
            this.txtNumPermiso.BorderSize = 1;
            this.txtNumPermiso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumPermiso.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumPermiso.Location = new System.Drawing.Point(164, 110);
            this.txtNumPermiso.MaxLength = 10;
            this.txtNumPermiso.Multiline = false;
            this.txtNumPermiso.Name = "txtNumPermiso";
            this.txtNumPermiso.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumPermiso.PasswordChar = false;
            this.txtNumPermiso.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumPermiso.PlaceholderText = "";
            this.txtNumPermiso.Size = new System.Drawing.Size(129, 36);
            this.txtNumPermiso.TabIndex = 27;
            this.txtNumPermiso.Texts = "";
            this.txtNumPermiso.UnderlinedStyle = false;
            this.txtNumPermiso._TextChanged += new System.EventHandler(this.txtNumPermiso__TextChanged);
            this.txtNumPermiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPermiso_KeyPress);
            // 
            // cboTipoAforo
            // 
            this.cboTipoAforo.BackColor = System.Drawing.SystemColors.Window;
            this.cboTipoAforo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoAforo.BorderSize = 1;
            this.cboTipoAforo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAforo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoAforo.ForeColor = System.Drawing.Color.DimGray;
            this.cboTipoAforo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoAforo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTipoAforo.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTipoAforo.Location = new System.Drawing.Point(164, 68);
            this.cboTipoAforo.MinimumSize = new System.Drawing.Size(120, 30);
            this.cboTipoAforo.Name = "cboTipoAforo";
            this.cboTipoAforo.Padding = new System.Windows.Forms.Padding(1);
            this.cboTipoAforo.Size = new System.Drawing.Size(129, 36);
            this.cboTipoAforo.TabIndex = 25;
            this.cboTipoAforo.Texts = "";
            this.cboTipoAforo.OnSelectedIndexChanged += new System.EventHandler(this.cboTipoAforo_OnSelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 8;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(593, 666);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 40);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "SALIR";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConsultasAfElec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(924, 718);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelModif);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.txtComprobante);
            this.Controls.Add(this.txtObserv);
            this.Controls.Add(this.cboInspector);
            this.Controls.Add(this.cboLocalidad);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtIniciador);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.cboTipoObraConex);
            this.Controls.Add(this.cboTipoMed);
            this.Controls.Add(this.cboTipoConex);
            this.Controls.Add(this.txtLetraExp);
            this.Controls.Add(this.txtNumExp);
            this.Controls.Add(this.txtAnioExp);
            this.Controls.Add(this.lblLetraExp);
            this.Controls.Add(this.lblNumExp);
            this.Controls.Add(this.lblAnioExp);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.lblObserv);
            this.Controls.Add(this.lblInspec);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.lblDom);
            this.Controls.Add(this.lblIniciador);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.lblTipoOb);
            this.Controls.Add(this.lblTipoMed);
            this.Controls.Add(this.lblTipoCon);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblNumPermiso);
            this.Controls.Add(this.txtNumPermiso);
            this.Controls.Add(this.lblDescTipo);
            this.Controls.Add(this.cboTipoAforo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvListadoPerCE);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(924, 718);
            this.Name = "frmConsultasAfElec";
            this.Load += new System.EventHandler(this.frmConsultasAfElec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPerCE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.CButton btnCancelar;
        private System.Windows.Forms.DataGridView dgvListadoPerCE;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblTipo;
        private ControlesPersonalizados.CComboBox cboTipoAforo;
        private System.Windows.Forms.Label lblDescTipo;
        private ControlesPersonalizados.txtExterior txtNumPermiso;
        private System.Windows.Forms.Label lblNumPermiso;
        private ControlesPersonalizados.CButton btnImprimir;
        private ControlesPersonalizados.CButton btnModificar;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblObserv;
        private System.Windows.Forms.Label lblInspec;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblDom;
        private System.Windows.Forms.Label lblIniciador;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Label lblTipoOb;
        private System.Windows.Forms.Label lblTipoMed;
        private System.Windows.Forms.Label lblTipoCon;
        private System.Windows.Forms.Label lblExp;
        private ControlesPersonalizados.txtExterior txtLetraExp;
        private ControlesPersonalizados.txtExterior txtNumExp;
        private ControlesPersonalizados.txtExterior txtAnioExp;
        private System.Windows.Forms.Label lblLetraExp;
        private System.Windows.Forms.Label lblNumExp;
        private System.Windows.Forms.Label lblAnioExp;
        private ControlesPersonalizados.CComboBox cboTipoObraConex;
        private ControlesPersonalizados.CComboBox cboTipoMed;
        private ControlesPersonalizados.CComboBox cboTipoConex;
        private ControlesPersonalizados.txtExterior txtDomicilio;
        private ControlesPersonalizados.txtExterior txtIniciador;
        private System.Windows.Forms.Label lblDias;
        private ControlesPersonalizados.txtExterior txtDias;
        private ControlesPersonalizados.txtExterior txtPotencia;
        private ControlesPersonalizados.CComboBox cboInspector;
        private ControlesPersonalizados.CComboBox cboLocalidad;
        private ControlesPersonalizados.txtExterior txtObserv;
        private ControlesPersonalizados.txtExterior txtComprobante;
        private ControlesPersonalizados.txtExterior txtImporte;
        private System.Windows.Forms.Label lblImporte;
        private ControlesPersonalizados.CButton btnGuardar;
        private ControlesPersonalizados.CButton btnCancelModif;
    }
}