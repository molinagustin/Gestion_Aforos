
namespace CPresentacion.Formularios.Usuarios
{
    partial class frmCambioContra
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
            this.btnCancelar = new CPresentacion.ControlesPersonalizados.CButton();
            this.btnAceptar = new CPresentacion.ControlesPersonalizados.CButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombreUs = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.lblNombreUs = new System.Windows.Forms.Label();
            this.txtContraActual = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.lblContraAct = new System.Windows.Forms.Label();
            this.txtNuevaContra = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.lblNuevaContra = new System.Windows.Forms.Label();
            this.txtRepContra = new CPresentacion.ControlesPersonalizados.txtExterior();
            this.lblRepetContra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(216, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnAceptar.BorderRadius = 10;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(63, 216);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(132, 40);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(389, 27);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "CAMBIAR CONTRASEÑA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreUs
            // 
            this.txtNombreUs.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreUs.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreUs.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreUs.BorderRadius = 8;
            this.txtNombreUs.BorderSize = 1;
            this.txtNombreUs.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNombreUs.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreUs.Location = new System.Drawing.Point(171, 48);
            this.txtNombreUs.MaxLength = 20;
            this.txtNombreUs.Multiline = false;
            this.txtNombreUs.Name = "txtNombreUs";
            this.txtNombreUs.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreUs.PasswordChar = false;
            this.txtNombreUs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreUs.PlaceholderText = "";
            this.txtNombreUs.Size = new System.Drawing.Size(203, 32);
            this.txtNombreUs.TabIndex = 1;
            this.txtNombreUs.Texts = "";
            this.txtNombreUs.UnderlinedStyle = false;
            this.txtNombreUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUs_KeyPress);
            // 
            // lblNombreUs
            // 
            this.lblNombreUs.AutoSize = true;
            this.lblNombreUs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNombreUs.Location = new System.Drawing.Point(22, 54);
            this.lblNombreUs.Name = "lblNombreUs";
            this.lblNombreUs.Size = new System.Drawing.Size(126, 21);
            this.lblNombreUs.TabIndex = 49;
            this.lblNombreUs.Text = "Nombre Usuario";
            this.lblNombreUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContraActual
            // 
            this.txtContraActual.BackColor = System.Drawing.SystemColors.Window;
            this.txtContraActual.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtContraActual.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtContraActual.BorderRadius = 8;
            this.txtContraActual.BorderSize = 1;
            this.txtContraActual.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtContraActual.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraActual.Location = new System.Drawing.Point(171, 89);
            this.txtContraActual.MaxLength = 20;
            this.txtContraActual.Multiline = false;
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContraActual.PasswordChar = true;
            this.txtContraActual.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContraActual.PlaceholderText = "";
            this.txtContraActual.Size = new System.Drawing.Size(203, 32);
            this.txtContraActual.TabIndex = 2;
            this.txtContraActual.Texts = "";
            this.txtContraActual.UnderlinedStyle = false;
            // 
            // lblContraAct
            // 
            this.lblContraAct.AutoSize = true;
            this.lblContraAct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblContraAct.Location = new System.Drawing.Point(22, 95);
            this.lblContraAct.Name = "lblContraAct";
            this.lblContraAct.Size = new System.Drawing.Size(136, 21);
            this.lblContraAct.TabIndex = 51;
            this.lblContraAct.Text = "Contraseña Actual";
            this.lblContraAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNuevaContra
            // 
            this.txtNuevaContra.BackColor = System.Drawing.SystemColors.Window;
            this.txtNuevaContra.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNuevaContra.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNuevaContra.BorderRadius = 8;
            this.txtNuevaContra.BorderSize = 1;
            this.txtNuevaContra.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNuevaContra.ForeColor = System.Drawing.Color.DimGray;
            this.txtNuevaContra.Location = new System.Drawing.Point(171, 130);
            this.txtNuevaContra.MaxLength = 20;
            this.txtNuevaContra.Multiline = false;
            this.txtNuevaContra.Name = "txtNuevaContra";
            this.txtNuevaContra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNuevaContra.PasswordChar = true;
            this.txtNuevaContra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNuevaContra.PlaceholderText = "";
            this.txtNuevaContra.Size = new System.Drawing.Size(203, 32);
            this.txtNuevaContra.TabIndex = 3;
            this.txtNuevaContra.Texts = "";
            this.txtNuevaContra.UnderlinedStyle = false;
            // 
            // lblNuevaContra
            // 
            this.lblNuevaContra.AutoSize = true;
            this.lblNuevaContra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNuevaContra.Location = new System.Drawing.Point(22, 136);
            this.lblNuevaContra.Name = "lblNuevaContra";
            this.lblNuevaContra.Size = new System.Drawing.Size(138, 21);
            this.lblNuevaContra.TabIndex = 53;
            this.lblNuevaContra.Text = "Nueva Contraseña";
            this.lblNuevaContra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRepContra
            // 
            this.txtRepContra.BackColor = System.Drawing.SystemColors.Window;
            this.txtRepContra.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRepContra.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRepContra.BorderRadius = 8;
            this.txtRepContra.BorderSize = 1;
            this.txtRepContra.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRepContra.ForeColor = System.Drawing.Color.DimGray;
            this.txtRepContra.Location = new System.Drawing.Point(171, 171);
            this.txtRepContra.MaxLength = 20;
            this.txtRepContra.Multiline = false;
            this.txtRepContra.Name = "txtRepContra";
            this.txtRepContra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRepContra.PasswordChar = true;
            this.txtRepContra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRepContra.PlaceholderText = "";
            this.txtRepContra.Size = new System.Drawing.Size(203, 32);
            this.txtRepContra.TabIndex = 4;
            this.txtRepContra.Texts = "";
            this.txtRepContra.UnderlinedStyle = false;
            // 
            // lblRepetContra
            // 
            this.lblRepetContra.AutoSize = true;
            this.lblRepetContra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRepetContra.Location = new System.Drawing.Point(22, 177);
            this.lblRepetContra.Name = "lblRepetContra";
            this.lblRepetContra.Size = new System.Drawing.Size(143, 21);
            this.lblRepetContra.TabIndex = 55;
            this.lblRepetContra.Text = "Repetir Contraseña";
            this.lblRepetContra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCambioContra
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(413, 268);
            this.ControlBox = false;
            this.Controls.Add(this.txtRepContra);
            this.Controls.Add(this.lblRepetContra);
            this.Controls.Add(this.txtNuevaContra);
            this.Controls.Add(this.lblNuevaContra);
            this.Controls.Add(this.txtContraActual);
            this.Controls.Add(this.lblContraAct);
            this.Controls.Add(this.txtNombreUs);
            this.Controls.Add(this.lblNombreUs);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambioContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.CButton btnCancelar;
        private ControlesPersonalizados.CButton btnAceptar;
        private System.Windows.Forms.Label lblTitulo;
        private ControlesPersonalizados.txtExterior txtNombreUs;
        private System.Windows.Forms.Label lblNombreUs;
        private ControlesPersonalizados.txtExterior txtContraActual;
        private System.Windows.Forms.Label lblContraAct;
        private ControlesPersonalizados.txtExterior txtNuevaContra;
        private System.Windows.Forms.Label lblNuevaContra;
        private ControlesPersonalizados.txtExterior txtRepContra;
        private System.Windows.Forms.Label lblRepetContra;
    }
}