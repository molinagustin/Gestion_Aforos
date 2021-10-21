
namespace CPresentacion.Formularios.Aforos.Electricos
{
    partial class frmEntregaPermiso
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblTipoCon = new System.Windows.Forms.Label();
            this.lblTipoMed = new System.Windows.Forms.Label();
            this.lblTipoOb = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.lblObserv = new System.Windows.Forms.Label();
            this.lblInspec = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblDom = new System.Windows.Forms.Label();
            this.lblIniciador = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblAnioExp = new System.Windows.Forms.Label();
            this.lblNumExp = new System.Windows.Forms.Label();
            this.lblLetraExp = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblNumComp = new System.Windows.Forms.Label();
            this.lblAnioComp = new System.Windows.Forms.Label();
            this.cboInspector = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.cboLocalidad = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.cboTipoObraConex = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.cboTipoMed = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.cboTipoConex = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.btnCancelar = new CPresentacion.ControlesPersonalizados.CButton();
            this.btnLimpiar = new CPresentacion.ControlesPersonalizados.CButton();
            this.btnGenerar = new CPresentacion.ControlesPersonalizados.CButton();
            this.txtImporte = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtNumComp = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtAnioComp = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtObserv = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtDomicilio = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtIniciador = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtDias = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtPotencia = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtLetraExp = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtNumExp = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtAnioExp = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(760, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PERMISO DE CONEXION ELECTRICA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExp
            // 
            this.lblExp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblExp.Location = new System.Drawing.Point(46, 117);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(105, 21);
            this.lblExp.TabIndex = 1;
            this.lblExp.Text = "EXPEDIENTE";
            this.lblExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoCon
            // 
            this.lblTipoCon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoCon.AutoSize = true;
            this.lblTipoCon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipoCon.Location = new System.Drawing.Point(46, 167);
            this.lblTipoCon.Name = "lblTipoCon";
            this.lblTipoCon.Size = new System.Drawing.Size(134, 21);
            this.lblTipoCon.TabIndex = 3;
            this.lblTipoCon.Text = "TIPO CONEXION";
            this.lblTipoCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoMed
            // 
            this.lblTipoMed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoMed.AutoSize = true;
            this.lblTipoMed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipoMed.Location = new System.Drawing.Point(46, 217);
            this.lblTipoMed.Name = "lblTipoMed";
            this.lblTipoMed.Size = new System.Drawing.Size(125, 21);
            this.lblTipoMed.TabIndex = 4;
            this.lblTipoMed.Text = "TIPO MEDIDOR";
            this.lblTipoMed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoOb
            // 
            this.lblTipoOb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoOb.AutoSize = true;
            this.lblTipoOb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipoOb.Location = new System.Drawing.Point(46, 267);
            this.lblTipoOb.Name = "lblTipoOb";
            this.lblTipoOb.Size = new System.Drawing.Size(151, 21);
            this.lblTipoOb.TabIndex = 5;
            this.lblTipoOb.Text = "TIPO OBRA CONEX";
            this.lblTipoOb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPotencia
            // 
            this.lblPotencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPotencia.Location = new System.Drawing.Point(46, 317);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(126, 21);
            this.lblPotencia.TabIndex = 6;
            this.lblPotencia.Text = "POTENCIA (HP)";
            this.lblPotencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObserv
            // 
            this.lblObserv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblObserv.AutoSize = true;
            this.lblObserv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblObserv.Location = new System.Drawing.Point(46, 567);
            this.lblObserv.Name = "lblObserv";
            this.lblObserv.Size = new System.Drawing.Size(139, 21);
            this.lblObserv.TabIndex = 11;
            this.lblObserv.Text = "OBSERVACIONES";
            this.lblObserv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInspec
            // 
            this.lblInspec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInspec.AutoSize = true;
            this.lblInspec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInspec.Location = new System.Drawing.Point(46, 517);
            this.lblInspec.Name = "lblInspec";
            this.lblInspec.Size = new System.Drawing.Size(96, 21);
            this.lblInspec.TabIndex = 10;
            this.lblInspec.Text = "INSPECTOR";
            this.lblInspec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoc
            // 
            this.lblLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoc.Location = new System.Drawing.Point(46, 467);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(99, 21);
            this.lblLoc.TabIndex = 9;
            this.lblLoc.Text = "LOCALIDAD";
            this.lblLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDom
            // 
            this.lblDom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDom.AutoSize = true;
            this.lblDom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDom.Location = new System.Drawing.Point(46, 417);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(94, 21);
            this.lblDom.TabIndex = 8;
            this.lblDom.Text = "DOMICILIO";
            this.lblDom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIniciador
            // 
            this.lblIniciador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIniciador.AutoSize = true;
            this.lblIniciador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblIniciador.Location = new System.Drawing.Point(46, 367);
            this.lblIniciador.Name = "lblIniciador";
            this.lblIniciador.Size = new System.Drawing.Size(93, 21);
            this.lblIniciador.TabIndex = 7;
            this.lblIniciador.Text = "INICIADOR";
            this.lblIniciador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComp
            // 
            this.lblComp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblComp.Location = new System.Drawing.Point(46, 617);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(131, 21);
            this.lblComp.TabIndex = 12;
            this.lblComp.Text = "COMPROBANTE";
            this.lblComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnioExp
            // 
            this.lblAnioExp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAnioExp.AutoSize = true;
            this.lblAnioExp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAnioExp.Location = new System.Drawing.Point(234, 117);
            this.lblAnioExp.Name = "lblAnioExp";
            this.lblAnioExp.Size = new System.Drawing.Size(38, 21);
            this.lblAnioExp.TabIndex = 13;
            this.lblAnioExp.Text = "Año";
            this.lblAnioExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumExp
            // 
            this.lblNumExp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumExp.AutoSize = true;
            this.lblNumExp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNumExp.Location = new System.Drawing.Point(369, 117);
            this.lblNumExp.Name = "lblNumExp";
            this.lblNumExp.Size = new System.Drawing.Size(29, 21);
            this.lblNumExp.TabIndex = 14;
            this.lblNumExp.Text = "Nº";
            this.lblNumExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLetraExp
            // 
            this.lblLetraExp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLetraExp.AutoSize = true;
            this.lblLetraExp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLetraExp.Location = new System.Drawing.Point(563, 117);
            this.lblLetraExp.Name = "lblLetraExp";
            this.lblLetraExp.Size = new System.Drawing.Size(45, 21);
            this.lblLetraExp.TabIndex = 15;
            this.lblLetraExp.Text = "Letra";
            this.lblLetraExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDias
            // 
            this.lblDias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDias.Location = new System.Drawing.Point(445, 317);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(40, 21);
            this.lblDias.TabIndex = 24;
            this.lblDias.Text = "Dias";
            this.lblDias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImporte
            // 
            this.lblImporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblImporte.Location = new System.Drawing.Point(563, 617);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(65, 21);
            this.lblImporte.TabIndex = 34;
            this.lblImporte.Text = "Importe";
            this.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumComp
            // 
            this.lblNumComp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumComp.AutoSize = true;
            this.lblNumComp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNumComp.Location = new System.Drawing.Point(369, 617);
            this.lblNumComp.Name = "lblNumComp";
            this.lblNumComp.Size = new System.Drawing.Size(29, 21);
            this.lblNumComp.TabIndex = 33;
            this.lblNumComp.Text = "Nº";
            this.lblNumComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnioComp
            // 
            this.lblAnioComp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAnioComp.AutoSize = true;
            this.lblAnioComp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAnioComp.Location = new System.Drawing.Point(234, 617);
            this.lblAnioComp.Name = "lblAnioComp";
            this.lblAnioComp.Size = new System.Drawing.Size(38, 21);
            this.lblAnioComp.TabIndex = 32;
            this.lblAnioComp.Text = "Año";
            this.lblAnioComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboInspector
            // 
            this.cboInspector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboInspector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboInspector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboInspector.BackColor = System.Drawing.SystemColors.Window;
            this.cboInspector.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboInspector.BorderSize = 1;
            this.cboInspector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboInspector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInspector.ForeColor = System.Drawing.Color.DimGray;
            this.cboInspector.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboInspector.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboInspector.ListTextColor = System.Drawing.Color.DimGray;
            this.cboInspector.Location = new System.Drawing.Point(278, 509);
            this.cboInspector.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboInspector.Name = "cboInspector";
            this.cboInspector.Padding = new System.Windows.Forms.Padding(1);
            this.cboInspector.Size = new System.Drawing.Size(307, 36);
            this.cboInspector.TabIndex = 12;
            this.cboInspector.Texts = "";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLocalidad.BackColor = System.Drawing.SystemColors.Window;
            this.cboLocalidad.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLocalidad.BorderSize = 1;
            this.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLocalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocalidad.ForeColor = System.Drawing.Color.DimGray;
            this.cboLocalidad.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLocalidad.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLocalidad.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLocalidad.Location = new System.Drawing.Point(278, 459);
            this.cboLocalidad.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Padding = new System.Windows.Forms.Padding(1);
            this.cboLocalidad.Size = new System.Drawing.Size(240, 36);
            this.cboLocalidad.TabIndex = 11;
            this.cboLocalidad.Texts = "";
            // 
            // cboTipoObraConex
            // 
            this.cboTipoObraConex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTipoObraConex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTipoObraConex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoObraConex.BackColor = System.Drawing.SystemColors.Window;
            this.cboTipoObraConex.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoObraConex.BorderSize = 1;
            this.cboTipoObraConex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTipoObraConex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoObraConex.ForeColor = System.Drawing.Color.DimGray;
            this.cboTipoObraConex.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoObraConex.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTipoObraConex.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTipoObraConex.Location = new System.Drawing.Point(278, 259);
            this.cboTipoObraConex.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTipoObraConex.Name = "cboTipoObraConex";
            this.cboTipoObraConex.Padding = new System.Windows.Forms.Padding(1);
            this.cboTipoObraConex.Size = new System.Drawing.Size(461, 36);
            this.cboTipoObraConex.TabIndex = 6;
            this.cboTipoObraConex.Texts = "";
            // 
            // cboTipoMed
            // 
            this.cboTipoMed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTipoMed.BackColor = System.Drawing.SystemColors.Window;
            this.cboTipoMed.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoMed.BorderSize = 1;
            this.cboTipoMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMed.ForeColor = System.Drawing.Color.DimGray;
            this.cboTipoMed.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoMed.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTipoMed.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTipoMed.Location = new System.Drawing.Point(278, 209);
            this.cboTipoMed.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTipoMed.Name = "cboTipoMed";
            this.cboTipoMed.Padding = new System.Windows.Forms.Padding(1);
            this.cboTipoMed.Size = new System.Drawing.Size(240, 36);
            this.cboTipoMed.TabIndex = 5;
            this.cboTipoMed.Texts = "";
            // 
            // cboTipoConex
            // 
            this.cboTipoConex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTipoConex.BackColor = System.Drawing.SystemColors.Window;
            this.cboTipoConex.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoConex.BorderSize = 1;
            this.cboTipoConex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoConex.ForeColor = System.Drawing.Color.DimGray;
            this.cboTipoConex.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoConex.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTipoConex.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTipoConex.Location = new System.Drawing.Point(278, 159);
            this.cboTipoConex.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTipoConex.Name = "cboTipoConex";
            this.cboTipoConex.Padding = new System.Windows.Forms.Padding(1);
            this.cboTipoConex.Size = new System.Drawing.Size(240, 36);
            this.cboTipoConex.TabIndex = 4;
            this.cboTipoConex.Texts = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 8;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(526, 665);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 40);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiar.BorderRadius = 8;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(347, 665);
            this.btnLimpiar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnLimpiar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 40);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGenerar.BorderRadius = 8;
            this.btnGenerar.BorderSize = 0;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(168, 665);
            this.btnGenerar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnGenerar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(130, 40);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.TextColor = System.Drawing.Color.White;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtImporte.BackColor = System.Drawing.SystemColors.Window;
            this.txtImporte.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtImporte.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtImporte.BorderRadius = 8;
            this.txtImporte.BorderSize = 1;
            this.txtImporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtImporte.ForeColor = System.Drawing.Color.DimGray;
            this.txtImporte.Location = new System.Drawing.Point(634, 609);
            this.txtImporte.MaxLength = 8;
            this.txtImporte.Multiline = false;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtImporte.PasswordChar = false;
            this.txtImporte.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtImporte.PlaceholderText = "";
            this.txtImporte.Size = new System.Drawing.Size(105, 36);
            this.txtImporte.TabIndex = 16;
            this.txtImporte.Texts = "0,00";
            this.txtImporte.UnderlinedStyle = false;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtImporte.Leave += new System.EventHandler(this.txtImporte_Leave);
            // 
            // txtNumComp
            // 
            this.txtNumComp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumComp.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumComp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumComp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumComp.BorderRadius = 8;
            this.txtNumComp.BorderSize = 1;
            this.txtNumComp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumComp.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumComp.Location = new System.Drawing.Point(404, 609);
            this.txtNumComp.MaxLength = 10;
            this.txtNumComp.Multiline = false;
            this.txtNumComp.Name = "txtNumComp";
            this.txtNumComp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumComp.PasswordChar = false;
            this.txtNumComp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumComp.PlaceholderText = "";
            this.txtNumComp.Size = new System.Drawing.Size(129, 36);
            this.txtNumComp.TabIndex = 15;
            this.txtNumComp.Texts = "";
            this.txtNumComp.UnderlinedStyle = false;
            this.txtNumComp._TextChanged += new System.EventHandler(this.txtNumComp__TextChanged);
            this.txtNumComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumComp_KeyPress);
            // 
            // txtAnioComp
            // 
            this.txtAnioComp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAnioComp.BackColor = System.Drawing.SystemColors.Window;
            this.txtAnioComp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAnioComp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAnioComp.BorderRadius = 8;
            this.txtAnioComp.BorderSize = 1;
            this.txtAnioComp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAnioComp.ForeColor = System.Drawing.Color.DimGray;
            this.txtAnioComp.Location = new System.Drawing.Point(278, 609);
            this.txtAnioComp.MaxLength = 4;
            this.txtAnioComp.Multiline = false;
            this.txtAnioComp.Name = "txtAnioComp";
            this.txtAnioComp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAnioComp.PasswordChar = false;
            this.txtAnioComp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAnioComp.PlaceholderText = "";
            this.txtAnioComp.Size = new System.Drawing.Size(70, 36);
            this.txtAnioComp.TabIndex = 14;
            this.txtAnioComp.Texts = "";
            this.txtAnioComp.UnderlinedStyle = false;
            this.txtAnioComp._TextChanged += new System.EventHandler(this.txtAnioComp__TextChanged);
            this.txtAnioComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnioComp_KeyPress);
            // 
            // txtObserv
            // 
            this.txtObserv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtObserv.BackColor = System.Drawing.SystemColors.Window;
            this.txtObserv.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtObserv.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtObserv.BorderRadius = 8;
            this.txtObserv.BorderSize = 1;
            this.txtObserv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtObserv.ForeColor = System.Drawing.Color.DimGray;
            this.txtObserv.Location = new System.Drawing.Point(278, 559);
            this.txtObserv.MaxLength = 200;
            this.txtObserv.Multiline = false;
            this.txtObserv.Name = "txtObserv";
            this.txtObserv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtObserv.PasswordChar = false;
            this.txtObserv.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObserv.PlaceholderText = "";
            this.txtObserv.Size = new System.Drawing.Size(461, 36);
            this.txtObserv.TabIndex = 13;
            this.txtObserv.Texts = "";
            this.txtObserv.UnderlinedStyle = false;
            this.txtObserv.Leave += new System.EventHandler(this.txtObserv_Leave);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDomicilio.BackColor = System.Drawing.SystemColors.Window;
            this.txtDomicilio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDomicilio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDomicilio.BorderRadius = 8;
            this.txtDomicilio.BorderSize = 1;
            this.txtDomicilio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDomicilio.ForeColor = System.Drawing.Color.DimGray;
            this.txtDomicilio.Location = new System.Drawing.Point(278, 409);
            this.txtDomicilio.MaxLength = 120;
            this.txtDomicilio.Multiline = false;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDomicilio.PasswordChar = false;
            this.txtDomicilio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDomicilio.PlaceholderText = "";
            this.txtDomicilio.Size = new System.Drawing.Size(461, 36);
            this.txtDomicilio.TabIndex = 10;
            this.txtDomicilio.Texts = "";
            this.txtDomicilio.UnderlinedStyle = false;
            this.txtDomicilio.Leave += new System.EventHandler(this.txtDomicilio_Leave);
            // 
            // txtIniciador
            // 
            this.txtIniciador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIniciador.BackColor = System.Drawing.SystemColors.Window;
            this.txtIniciador.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIniciador.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIniciador.BorderRadius = 8;
            this.txtIniciador.BorderSize = 1;
            this.txtIniciador.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIniciador.ForeColor = System.Drawing.Color.DimGray;
            this.txtIniciador.Location = new System.Drawing.Point(278, 359);
            this.txtIniciador.MaxLength = 100;
            this.txtIniciador.Multiline = false;
            this.txtIniciador.Name = "txtIniciador";
            this.txtIniciador.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIniciador.PasswordChar = false;
            this.txtIniciador.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIniciador.PlaceholderText = "";
            this.txtIniciador.Size = new System.Drawing.Size(461, 36);
            this.txtIniciador.TabIndex = 9;
            this.txtIniciador.Texts = "";
            this.txtIniciador.UnderlinedStyle = false;
            this.txtIniciador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIniciador_KeyPress);
            this.txtIniciador.Leave += new System.EventHandler(this.txtIniciador_Leave);
            // 
            // txtDias
            // 
            this.txtDias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDias.BackColor = System.Drawing.SystemColors.Window;
            this.txtDias.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDias.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDias.BorderRadius = 8;
            this.txtDias.BorderSize = 1;
            this.txtDias.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDias.ForeColor = System.Drawing.Color.DimGray;
            this.txtDias.Location = new System.Drawing.Point(491, 309);
            this.txtDias.MaxLength = 3;
            this.txtDias.Multiline = false;
            this.txtDias.Name = "txtDias";
            this.txtDias.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDias.PasswordChar = false;
            this.txtDias.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDias.PlaceholderText = "";
            this.txtDias.Size = new System.Drawing.Size(94, 36);
            this.txtDias.TabIndex = 8;
            this.txtDias.Texts = "-";
            this.txtDias.UnderlinedStyle = false;
            this.txtDias._TextChanged += new System.EventHandler(this.txtDias__TextChanged);
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            this.txtDias.Leave += new System.EventHandler(this.txtDias_Leave);
            // 
            // txtPotencia
            // 
            this.txtPotencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPotencia.BackColor = System.Drawing.SystemColors.Window;
            this.txtPotencia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPotencia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPotencia.BorderRadius = 8;
            this.txtPotencia.BorderSize = 1;
            this.txtPotencia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPotencia.ForeColor = System.Drawing.Color.DimGray;
            this.txtPotencia.Location = new System.Drawing.Point(278, 309);
            this.txtPotencia.MaxLength = 6;
            this.txtPotencia.Multiline = false;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPotencia.PasswordChar = false;
            this.txtPotencia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPotencia.PlaceholderText = "";
            this.txtPotencia.Size = new System.Drawing.Size(120, 36);
            this.txtPotencia.TabIndex = 7;
            this.txtPotencia.Tag = "";
            this.txtPotencia.Texts = "0,00";
            this.txtPotencia.UnderlinedStyle = false;
            this.txtPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPotencia_KeyPress);
            this.txtPotencia.Leave += new System.EventHandler(this.txtPotencia_Leave);
            // 
            // txtLetraExp
            // 
            this.txtLetraExp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLetraExp.BackColor = System.Drawing.SystemColors.Window;
            this.txtLetraExp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLetraExp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLetraExp.BorderRadius = 8;
            this.txtLetraExp.BorderSize = 1;
            this.txtLetraExp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLetraExp.ForeColor = System.Drawing.Color.DimGray;
            this.txtLetraExp.Location = new System.Drawing.Point(614, 109);
            this.txtLetraExp.MaxLength = 3;
            this.txtLetraExp.Multiline = false;
            this.txtLetraExp.Name = "txtLetraExp";
            this.txtLetraExp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLetraExp.PasswordChar = false;
            this.txtLetraExp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLetraExp.PlaceholderText = "";
            this.txtLetraExp.Size = new System.Drawing.Size(66, 36);
            this.txtLetraExp.TabIndex = 3;
            this.txtLetraExp.Texts = "";
            this.txtLetraExp.UnderlinedStyle = false;
            this.txtLetraExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetraExp_KeyPress);
            this.txtLetraExp.Leave += new System.EventHandler(this.txtLetraExp_Leave);
            // 
            // txtNumExp
            // 
            this.txtNumExp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumExp.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumExp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumExp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumExp.BorderRadius = 8;
            this.txtNumExp.BorderSize = 1;
            this.txtNumExp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumExp.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumExp.Location = new System.Drawing.Point(404, 109);
            this.txtNumExp.MaxLength = 10;
            this.txtNumExp.Multiline = false;
            this.txtNumExp.Name = "txtNumExp";
            this.txtNumExp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumExp.PasswordChar = false;
            this.txtNumExp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumExp.PlaceholderText = "";
            this.txtNumExp.Size = new System.Drawing.Size(129, 36);
            this.txtNumExp.TabIndex = 2;
            this.txtNumExp.Texts = "";
            this.txtNumExp.UnderlinedStyle = false;
            this.txtNumExp._TextChanged += new System.EventHandler(this.txtNumExp__TextChanged);
            this.txtNumExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumExp_KeyPress);
            // 
            // txtAnioExp
            // 
            this.txtAnioExp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAnioExp.BackColor = System.Drawing.SystemColors.Window;
            this.txtAnioExp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAnioExp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAnioExp.BorderRadius = 8;
            this.txtAnioExp.BorderSize = 1;
            this.txtAnioExp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAnioExp.ForeColor = System.Drawing.Color.DimGray;
            this.txtAnioExp.Location = new System.Drawing.Point(278, 109);
            this.txtAnioExp.MaxLength = 4;
            this.txtAnioExp.Multiline = false;
            this.txtAnioExp.Name = "txtAnioExp";
            this.txtAnioExp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAnioExp.PasswordChar = false;
            this.txtAnioExp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAnioExp.PlaceholderText = "";
            this.txtAnioExp.Size = new System.Drawing.Size(70, 36);
            this.txtAnioExp.TabIndex = 1;
            this.txtAnioExp.Texts = "";
            this.txtAnioExp.UnderlinedStyle = false;
            this.txtAnioExp._TextChanged += new System.EventHandler(this.txtAnioExp__TextChanged);
            this.txtAnioExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnioExp_KeyPress);
            // 
            // frmEntregaPermiso
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 718);
            this.ControlBox = false;
            this.Controls.Add(this.cboInspector);
            this.Controls.Add(this.cboLocalidad);
            this.Controls.Add(this.cboTipoObraConex);
            this.Controls.Add(this.cboTipoMed);
            this.Controls.Add(this.cboTipoConex);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtNumComp);
            this.Controls.Add(this.txtAnioComp);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblNumComp);
            this.Controls.Add(this.lblAnioComp);
            this.Controls.Add(this.txtObserv);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtIniciador);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtPotencia);
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
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(784, 718);
            this.Name = "frmEntregaPermiso";
            this.Load += new System.EventHandler(this.frmEntregaPermiso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblTipoCon;
        private System.Windows.Forms.Label lblTipoMed;
        private System.Windows.Forms.Label lblTipoOb;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Label lblObserv;
        private System.Windows.Forms.Label lblInspec;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblDom;
        private System.Windows.Forms.Label lblIniciador;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblAnioExp;
        private System.Windows.Forms.Label lblNumExp;
        private System.Windows.Forms.Label lblLetraExp;
        private ControlesPersonalizados.txtExterior txtAnioExp;
        private ControlesPersonalizados.txtExterior txtNumExp;
        private ControlesPersonalizados.txtExterior txtLetraExp;
        private ControlesPersonalizados.txtExterior txtPotencia;
        private ControlesPersonalizados.txtExterior txtDias;
        private System.Windows.Forms.Label lblDias;
        private ControlesPersonalizados.txtExterior txtIniciador;
        private ControlesPersonalizados.txtExterior txtDomicilio;
        private ControlesPersonalizados.txtExterior txtObserv;
        private ControlesPersonalizados.txtExterior txtImporte;
        private ControlesPersonalizados.txtExterior txtNumComp;
        private ControlesPersonalizados.txtExterior txtAnioComp;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblNumComp;
        private System.Windows.Forms.Label lblAnioComp;
        private ControlesPersonalizados.CButton btnGenerar;
        private ControlesPersonalizados.CButton btnLimpiar;
        private ControlesPersonalizados.CButton btnCancelar;
        private ControlesPersonalizados.CComboBox cboTipoConex;
        private ControlesPersonalizados.CComboBox cboTipoMed;
        private ControlesPersonalizados.CComboBox cboTipoObraConex;
        private ControlesPersonalizados.CComboBox cboLocalidad;
        private ControlesPersonalizados.CComboBox cboInspector;
    }
}