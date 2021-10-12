
namespace CPresentacion.ControlesPersonalizados
{
    partial class txtExterior
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInterior = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInterior
            // 
            this.txtInterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInterior.Location = new System.Drawing.Point(10, 7);
            this.txtInterior.Name = "txtInterior";
            this.txtInterior.Size = new System.Drawing.Size(230, 17);
            this.txtInterior.TabIndex = 0;
            this.txtInterior.Click += new System.EventHandler(this.txtInterior_Click);
            this.txtInterior.TextChanged += new System.EventHandler(this.txtInterior_TextChanged);
            this.txtInterior.Enter += new System.EventHandler(this.txtInterior_Enter);
            this.txtInterior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterior_KeyPress);
            this.txtInterior.Leave += new System.EventHandler(this.txtInterior_Leave);
            this.txtInterior.MouseEnter += new System.EventHandler(this.txtInterior_MouseEnter);
            this.txtInterior.MouseLeave += new System.EventHandler(this.txtInterior_MouseLeave);
            // 
            // txtExterior
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.txtInterior);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "txtExterior";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInterior;
    }
}
