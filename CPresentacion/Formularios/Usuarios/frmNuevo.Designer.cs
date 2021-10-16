
namespace CPresentacion.Formularios.Usuarios
{
    partial class frmNuevo
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
            this.lblCuil = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombUs = new System.Windows.Forms.Label();
            this.lblPass1 = new System.Windows.Forms.Label();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.lblTipoUs = new System.Windows.Forms.Label();
            this.lblAccesos = new System.Windows.Forms.Label();
            this.chkAfoElect = new System.Windows.Forms.CheckBox();
            this.chkPermisosElect = new System.Windows.Forms.CheckBox();
            this.cboTipoUs = new CPresentacion.ControlesPersonalizados.CComboBox();
            this.txtPass2 = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtPass1 = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtNombreUs = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtNombre = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtApellido = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.txtCuil = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.btnCancelar = new CPresentacion.ControlesPersonalizados.CButton();
            this.btnGuardar = new CPresentacion.ControlesPersonalizados.CButton();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(744, 45);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ALTA DE USUARIO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCuil
            // 
            this.lblCuil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCuil.Location = new System.Drawing.Point(52, 128);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(45, 21);
            this.lblCuil.TabIndex = 2;
            this.lblCuil.Text = "CUIL";
            this.lblCuil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(435, 192);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 21);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(52, 192);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(85, 21);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "APELLIDO";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombUs
            // 
            this.lblNombUs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNombUs.AutoSize = true;
            this.lblNombUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombUs.Location = new System.Drawing.Point(52, 256);
            this.lblNombUs.Name = "lblNombUs";
            this.lblNombUs.Size = new System.Drawing.Size(154, 21);
            this.lblNombUs.TabIndex = 5;
            this.lblNombUs.Text = "NOMBRE USUARIO";
            this.lblNombUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPass1
            // 
            this.lblPass1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPass1.AutoSize = true;
            this.lblPass1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPass1.Location = new System.Drawing.Point(52, 320);
            this.lblPass1.Name = "lblPass1";
            this.lblPass1.Size = new System.Drawing.Size(117, 21);
            this.lblPass1.TabIndex = 6;
            this.lblPass1.Text = "CONTRASEÑA";
            this.lblPass1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPass2
            // 
            this.lblPass2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPass2.AutoSize = true;
            this.lblPass2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPass2.Location = new System.Drawing.Point(52, 384);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(183, 21);
            this.lblPass2.TabIndex = 7;
            this.lblPass2.Text = "REPETIR CONTRASEÑA";
            this.lblPass2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoUs
            // 
            this.lblTipoUs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTipoUs.AutoSize = true;
            this.lblTipoUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipoUs.Location = new System.Drawing.Point(52, 448);
            this.lblTipoUs.Name = "lblTipoUs";
            this.lblTipoUs.Size = new System.Drawing.Size(121, 21);
            this.lblTipoUs.TabIndex = 8;
            this.lblTipoUs.Text = "TIPO USUARIO";
            this.lblTipoUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccesos
            // 
            this.lblAccesos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAccesos.AutoSize = true;
            this.lblAccesos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccesos.Location = new System.Drawing.Point(52, 512);
            this.lblAccesos.Name = "lblAccesos";
            this.lblAccesos.Size = new System.Drawing.Size(80, 21);
            this.lblAccesos.TabIndex = 9;
            this.lblAccesos.Text = "ACCESOS";
            this.lblAccesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAfoElect
            // 
            this.chkAfoElect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkAfoElect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkAfoElect.Location = new System.Drawing.Point(244, 508);
            this.chkAfoElect.Name = "chkAfoElect";
            this.chkAfoElect.Size = new System.Drawing.Size(206, 31);
            this.chkAfoElect.TabIndex = 8;
            this.chkAfoElect.Text = "Aprobaciones Electricas";
            this.chkAfoElect.UseVisualStyleBackColor = true;
            // 
            // chkPermisosElect
            // 
            this.chkPermisosElect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkPermisosElect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkPermisosElect.Location = new System.Drawing.Point(244, 545);
            this.chkPermisosElect.Name = "chkPermisosElect";
            this.chkPermisosElect.Size = new System.Drawing.Size(173, 31);
            this.chkPermisosElect.TabIndex = 9;
            this.chkPermisosElect.Text = "Permisos Conexion";
            this.chkPermisosElect.UseVisualStyleBackColor = true;
            // 
            // cboTipoUs
            // 
            this.cboTipoUs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.cboTipoUs.Location = new System.Drawing.Point(244, 443);
            this.cboTipoUs.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTipoUs.Name = "cboTipoUs";
            this.cboTipoUs.Padding = new System.Windows.Forms.Padding(1);
            this.cboTipoUs.Size = new System.Drawing.Size(220, 30);
            this.cboTipoUs.TabIndex = 7;
            this.cboTipoUs.Texts = "";
            // 
            // txtPass2
            // 
            this.txtPass2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPass2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPass2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPass2.BorderRadius = 8;
            this.txtPass2.BorderSize = 1;
            this.txtPass2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass2.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass2.Location = new System.Drawing.Point(244, 376);
            this.txtPass2.Multiline = false;
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass2.PasswordChar = true;
            this.txtPass2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPass2.PlaceholderText = "";
            this.txtPass2.Size = new System.Drawing.Size(179, 36);
            this.txtPass2.TabIndex = 6;
            this.txtPass2.Texts = "";
            this.txtPass2.UnderlinedStyle = false;
            // 
            // txtPass1
            // 
            this.txtPass1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPass1.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPass1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPass1.BorderRadius = 8;
            this.txtPass1.BorderSize = 1;
            this.txtPass1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass1.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass1.Location = new System.Drawing.Point(244, 312);
            this.txtPass1.Multiline = false;
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass1.PasswordChar = true;
            this.txtPass1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPass1.PlaceholderText = "";
            this.txtPass1.Size = new System.Drawing.Size(179, 36);
            this.txtPass1.TabIndex = 5;
            this.txtPass1.Texts = "";
            this.txtPass1.UnderlinedStyle = false;
            // 
            // txtNombreUs
            // 
            this.txtNombreUs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNombreUs.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreUs.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreUs.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreUs.BorderRadius = 8;
            this.txtNombreUs.BorderSize = 1;
            this.txtNombreUs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombreUs.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreUs.Location = new System.Drawing.Point(244, 248);
            this.txtNombreUs.MaxLength = 15;
            this.txtNombreUs.Multiline = false;
            this.txtNombreUs.Name = "txtNombreUs";
            this.txtNombreUs.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreUs.PasswordChar = false;
            this.txtNombreUs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreUs.PlaceholderText = "";
            this.txtNombreUs.Size = new System.Drawing.Size(179, 36);
            this.txtNombreUs.TabIndex = 4;
            this.txtNombreUs.Texts = "";
            this.txtNombreUs.UnderlinedStyle = false;
            this.txtNombreUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUs_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombre.BorderRadius = 8;
            this.txtNombre.BorderSize = 1;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(520, 184);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(179, 36);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtApellido.BorderRadius = 8;
            this.txtApellido.BorderSize = 1;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(244, 184);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellido.PlaceholderText = "";
            this.txtApellido.Size = new System.Drawing.Size(179, 36);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Texts = "";
            this.txtApellido.UnderlinedStyle = false;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtCuil
            // 
            this.txtCuil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCuil.BackColor = System.Drawing.SystemColors.Window;
            this.txtCuil.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCuil.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCuil.BorderRadius = 8;
            this.txtCuil.BorderSize = 1;
            this.txtCuil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCuil.ForeColor = System.Drawing.Color.DimGray;
            this.txtCuil.Location = new System.Drawing.Point(244, 120);
            this.txtCuil.MaxLength = 11;
            this.txtCuil.Multiline = false;
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCuil.PasswordChar = false;
            this.txtCuil.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCuil.PlaceholderText = "";
            this.txtCuil.Size = new System.Drawing.Size(179, 36);
            this.txtCuil.TabIndex = 1;
            this.txtCuil.Texts = "";
            this.txtCuil.UnderlinedStyle = false;
            this.txtCuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuil_KeyPress);
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
            this.btnCancelar.Location = new System.Drawing.Point(410, 633);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 8;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(181, 633);
            this.btnGuardar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnGuardar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 40);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmNuevo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(768, 702);
            this.ControlBox = false;
            this.Controls.Add(this.cboTipoUs);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.txtNombreUs);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkPermisosElect);
            this.Controls.Add(this.chkAfoElect);
            this.Controls.Add(this.lblAccesos);
            this.Controls.Add(this.lblTipoUs);
            this.Controls.Add(this.lblPass2);
            this.Controls.Add(this.lblPass1);
            this.Controls.Add(this.lblNombUs);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(768, 702);
            this.Name = "frmNuevo";
            this.Load += new System.EventHandler(this.frmNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombUs;
        private System.Windows.Forms.Label lblPass1;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.Label lblTipoUs;
        private System.Windows.Forms.Label lblAccesos;
        private System.Windows.Forms.CheckBox chkAfoElect;
        private System.Windows.Forms.CheckBox chkPermisosElect;
        private ControlesPersonalizados.CButton btnGuardar;
        private ControlesPersonalizados.CButton btnCancelar;
        private ControlesPersonalizados.txtExterior txtCuil;
        private ControlesPersonalizados.txtExterior txtApellido;
        private ControlesPersonalizados.txtExterior txtNombre;
        private ControlesPersonalizados.txtExterior txtNombreUs;
        private ControlesPersonalizados.txtExterior txtPass1;
        private ControlesPersonalizados.txtExterior txtPass2;
        private ControlesPersonalizados.CComboBox cboTipoUs;
    }
}