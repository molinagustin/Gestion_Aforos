
namespace CPresentacion.Formularios.Usuarios
{
    partial class frmConsultaModif
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
            this.dgvListadoUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCancelModif = new CPresentacion.ControlesPersonalizados.CButton();
            this.btnGuardar = new CPresentacion.ControlesPersonalizados.CButton();
            this.btnEliminar = new CPresentacion.ControlesPersonalizados.CButton();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscador = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.btnSalir = new CPresentacion.ControlesPersonalizados.CButton();
            this.btnModificar = new CPresentacion.ControlesPersonalizados.CButton();
            this.cboTipoUs = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.txtNombreUs = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtNombre = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtApellido = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtCuil = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.chkPermisosElect = new System.Windows.Forms.CheckBox();
            this.chkAfoElect = new System.Windows.Forms.CheckBox();
            this.lblAccesos = new System.Windows.Forms.Label();
            this.lblTipoUs = new System.Windows.Forms.Label();
            this.lblNombUs = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.btnReiniciarContra = new CPresentacion.ControlesPersonalizados.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(900, 45);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "CONSULTAS USUARIOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListadoUsuarios
            // 
            this.dgvListadoUsuarios.AllowUserToAddRows = false;
            this.dgvListadoUsuarios.AllowUserToDeleteRows = false;
            this.dgvListadoUsuarios.AllowUserToResizeRows = false;
            this.dgvListadoUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoUsuarios.Location = new System.Drawing.Point(12, 142);
            this.dgvListadoUsuarios.MultiSelect = false;
            this.dgvListadoUsuarios.Name = "dgvListadoUsuarios";
            this.dgvListadoUsuarios.ReadOnly = true;
            this.dgvListadoUsuarios.RowHeadersVisible = false;
            this.dgvListadoUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoUsuarios.Size = new System.Drawing.Size(374, 508);
            this.dgvListadoUsuarios.TabIndex = 24;
            this.dgvListadoUsuarios.TabStop = false;
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
            this.btnCancelModif.Location = new System.Drawing.Point(560, 666);
            this.btnCancelModif.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnCancelModif.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnCancelModif.Name = "btnCancelModif";
            this.btnCancelModif.Size = new System.Drawing.Size(130, 40);
            this.btnCancelModif.TabIndex = 66;
            this.btnCancelModif.Text = "CANCELAR";
            this.btnCancelModif.TextColor = System.Drawing.Color.White;
            this.btnCancelModif.UseVisualStyleBackColor = false;
            this.btnCancelModif.Visible = false;
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
            this.btnGuardar.Location = new System.Drawing.Point(198, 666);
            this.btnGuardar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnGuardar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 40);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 8;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(379, 666);
            this.btnEliminar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnEliminar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 40);
            this.btnEliminar.TabIndex = 64;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(105, 108);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(72, 21);
            this.lblBuscar.TabIndex = 67;
            this.lblBuscar.Text = "BUSCAR";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscador
            // 
            this.txtBuscador.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscador.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscador.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBuscador.BorderRadius = 8;
            this.txtBuscador.BorderSize = 1;
            this.txtBuscador.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBuscador.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscador.Location = new System.Drawing.Point(183, 100);
            this.txtBuscador.MaxLength = 20;
            this.txtBuscador.Multiline = false;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscador.PasswordChar = false;
            this.txtBuscador.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscador.PlaceholderText = "";
            this.txtBuscador.Size = new System.Drawing.Size(203, 36);
            this.txtBuscador.TabIndex = 1;
            this.txtBuscador.Texts = "";
            this.txtBuscador.UnderlinedStyle = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 8;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(560, 666);
            this.btnSalir.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnSalir.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 40);
            this.btnSalir.TabIndex = 69;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(198, 666);
            this.btnModificar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnModificar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 40);
            this.btnModificar.TabIndex = 70;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // cboTipoUs
            // 
            this.cboTipoUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoUs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTipoUs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoUs.BackColor = System.Drawing.SystemColors.Window;
            this.cboTipoUs.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoUs.BorderSize = 1;
            this.cboTipoUs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTipoUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoUs.ForeColor = System.Drawing.Color.DimGray;
            this.cboTipoUs.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoUs.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTipoUs.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTipoUs.Location = new System.Drawing.Point(634, 435);
            this.cboTipoUs.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTipoUs.Name = "cboTipoUs";
            this.cboTipoUs.Padding = new System.Windows.Forms.Padding(1);
            this.cboTipoUs.Size = new System.Drawing.Size(220, 30);
            this.cboTipoUs.TabIndex = 82;
            this.cboTipoUs.Texts = "";
            // 
            // txtNombreUs
            // 
            this.txtNombreUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUs.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreUs.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreUs.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreUs.BorderRadius = 8;
            this.txtNombreUs.BorderSize = 1;
            this.txtNombreUs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombreUs.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreUs.Location = new System.Drawing.Point(634, 364);
            this.txtNombreUs.MaxLength = 15;
            this.txtNombreUs.Multiline = false;
            this.txtNombreUs.Name = "txtNombreUs";
            this.txtNombreUs.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreUs.PasswordChar = false;
            this.txtNombreUs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreUs.PlaceholderText = "";
            this.txtNombreUs.Size = new System.Drawing.Size(179, 36);
            this.txtNombreUs.TabIndex = 76;
            this.txtNombreUs.Texts = "";
            this.txtNombreUs.UnderlinedStyle = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombre.BorderRadius = 8;
            this.txtNombre.BorderSize = 1;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(634, 296);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(220, 36);
            this.txtNombre.TabIndex = 74;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtApellido.BorderRadius = 8;
            this.txtApellido.BorderSize = 1;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(634, 228);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellido.PlaceholderText = "";
            this.txtApellido.Size = new System.Drawing.Size(220, 36);
            this.txtApellido.TabIndex = 73;
            this.txtApellido.Texts = "";
            this.txtApellido.UnderlinedStyle = false;
            // 
            // txtCuil
            // 
            this.txtCuil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuil.BackColor = System.Drawing.SystemColors.Window;
            this.txtCuil.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCuil.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCuil.BorderRadius = 8;
            this.txtCuil.BorderSize = 1;
            this.txtCuil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCuil.ForeColor = System.Drawing.Color.DimGray;
            this.txtCuil.Location = new System.Drawing.Point(634, 160);
            this.txtCuil.MaxLength = 11;
            this.txtCuil.Multiline = false;
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCuil.PasswordChar = false;
            this.txtCuil.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCuil.PlaceholderText = "";
            this.txtCuil.Size = new System.Drawing.Size(179, 36);
            this.txtCuil.TabIndex = 71;
            this.txtCuil.Texts = "";
            this.txtCuil.UnderlinedStyle = false;
            // 
            // chkPermisosElect
            // 
            this.chkPermisosElect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPermisosElect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkPermisosElect.Location = new System.Drawing.Point(634, 541);
            this.chkPermisosElect.Name = "chkPermisosElect";
            this.chkPermisosElect.Size = new System.Drawing.Size(173, 31);
            this.chkPermisosElect.TabIndex = 87;
            this.chkPermisosElect.Text = "Permisos Conexion";
            this.chkPermisosElect.UseVisualStyleBackColor = true;
            // 
            // chkAfoElect
            // 
            this.chkAfoElect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAfoElect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkAfoElect.Location = new System.Drawing.Point(634, 504);
            this.chkAfoElect.Name = "chkAfoElect";
            this.chkAfoElect.Size = new System.Drawing.Size(206, 31);
            this.chkAfoElect.TabIndex = 85;
            this.chkAfoElect.Text = "Aprobaciones Electricas";
            this.chkAfoElect.UseVisualStyleBackColor = true;
            // 
            // lblAccesos
            // 
            this.lblAccesos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccesos.AutoSize = true;
            this.lblAccesos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccesos.Location = new System.Drawing.Point(474, 508);
            this.lblAccesos.Name = "lblAccesos";
            this.lblAccesos.Size = new System.Drawing.Size(80, 21);
            this.lblAccesos.TabIndex = 86;
            this.lblAccesos.Text = "ACCESOS";
            this.lblAccesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoUs
            // 
            this.lblTipoUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoUs.AutoSize = true;
            this.lblTipoUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipoUs.Location = new System.Drawing.Point(474, 440);
            this.lblTipoUs.Name = "lblTipoUs";
            this.lblTipoUs.Size = new System.Drawing.Size(121, 21);
            this.lblTipoUs.TabIndex = 84;
            this.lblTipoUs.Text = "TIPO USUARIO";
            this.lblTipoUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombUs
            // 
            this.lblNombUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombUs.AutoSize = true;
            this.lblNombUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombUs.Location = new System.Drawing.Point(474, 372);
            this.lblNombUs.Name = "lblNombUs";
            this.lblNombUs.Size = new System.Drawing.Size(154, 21);
            this.lblNombUs.TabIndex = 79;
            this.lblNombUs.Text = "NOMBRE USUARIO";
            this.lblNombUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(474, 236);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(85, 21);
            this.lblApellido.TabIndex = 77;
            this.lblApellido.Text = "APELLIDO";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(474, 304);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 21);
            this.lblNombre.TabIndex = 75;
            this.lblNombre.Text = "NOMBRE";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCuil
            // 
            this.lblCuil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCuil.Location = new System.Drawing.Point(474, 168);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(45, 21);
            this.lblCuil.TabIndex = 72;
            this.lblCuil.Text = "CUIL";
            this.lblCuil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReiniciarContra
            // 
            this.btnReiniciarContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReiniciarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(190)))), ((int)(((byte)(211)))));
            this.btnReiniciarContra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(190)))), ((int)(((byte)(211)))));
            this.btnReiniciarContra.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReiniciarContra.BorderRadius = 8;
            this.btnReiniciarContra.BorderSize = 0;
            this.btnReiniciarContra.FlatAppearance.BorderSize = 0;
            this.btnReiniciarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciarContra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReiniciarContra.ForeColor = System.Drawing.Color.White;
            this.btnReiniciarContra.Location = new System.Drawing.Point(478, 578);
            this.btnReiniciarContra.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnReiniciarContra.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnReiniciarContra.Name = "btnReiniciarContra";
            this.btnReiniciarContra.Size = new System.Drawing.Size(130, 40);
            this.btnReiniciarContra.TabIndex = 88;
            this.btnReiniciarContra.Text = "REINICIAR CONTRASEÑA";
            this.btnReiniciarContra.TextColor = System.Drawing.Color.White;
            this.btnReiniciarContra.UseVisualStyleBackColor = false;
            // 
            // frmConsultaModif
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(924, 718);
            this.ControlBox = false;
            this.Controls.Add(this.btnReiniciarContra);
            this.Controls.Add(this.cboTipoUs);
            this.Controls.Add(this.txtNombreUs);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.chkPermisosElect);
            this.Controls.Add(this.chkAfoElect);
            this.Controls.Add(this.lblAccesos);
            this.Controls.Add(this.lblTipoUs);
            this.Controls.Add(this.lblNombUs);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnCancelModif);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvListadoUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(924, 718);
            this.Name = "frmConsultaModif";
            this.Load += new System.EventHandler(this.frmConsultaModif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvListadoUsuarios;
        private ControlesPersonalizados.CButton btnCancelModif;
        private ControlesPersonalizados.CButton btnGuardar;
        private ControlesPersonalizados.CButton btnEliminar;
        private System.Windows.Forms.Label lblBuscar;
        private ControlesPersonalizados.txtExterior txtBuscador;
        private ControlesPersonalizados.CButton btnSalir;
        private ControlesPersonalizados.CButton btnModificar;
        private ControlesPersonalizados.CComboBox cboTipoUs;
        private ControlesPersonalizados.txtExterior txtNombreUs;
        private ControlesPersonalizados.txtExterior txtNombre;
        private ControlesPersonalizados.txtExterior txtApellido;
        private ControlesPersonalizados.txtExterior txtCuil;
        private System.Windows.Forms.CheckBox chkPermisosElect;
        private System.Windows.Forms.CheckBox chkAfoElect;
        private System.Windows.Forms.Label lblAccesos;
        private System.Windows.Forms.Label lblTipoUs;
        private System.Windows.Forms.Label lblNombUs;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCuil;
        private ControlesPersonalizados.CButton btnReiniciarContra;
    }
}