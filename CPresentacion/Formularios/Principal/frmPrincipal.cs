using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CPresentacion.ControlesPersonalizados;
using CPresentacion.Formularios.Aforos.Electricos;
using CPresentacion.Formularios.Usuarios;
using CComun.Cache;

namespace CPresentacion.Formularios.Principal
{
    public partial class frmPrincipal : Form
    {
        //Campos
        private int borderSize = 2;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
        private Form currentChildForm;

        //Constructor
        public frmPrincipal()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            HabilitarControles();
            ddmAfoElect.PrimaryColor = Color.FromArgb(159, 161, 224);
            ddmUsuarios.PrimaryColor = Color.FromArgb(159, 161, 224);
            btnPerfil.Text = cacUsuario.Nombre.ToUpper() + " " + cacUsuario.Apellido.ToUpper();
        }

        #region Metodos
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panDesktop.Controls.Add(childForm);
            panDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CollapseMenu()
        {
            if (this.panMenuIzquierdo.Width > 200) //Collapse menu
            {
                panMenuIzquierdo.Width = 100;
                picLogoPrinc.Visible = false;
                btnEsconderMenu.Dock = DockStyle.Top;
                btnEsconderMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
                foreach (Button menuButton in panMenuIzquierdo.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panMenuIzquierdo.Width = 240;
                picLogoPrinc.Visible = true;
                btnEsconderMenu.Dock = DockStyle.None;
                btnEsconderMenu.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
                foreach (Button menuButton in panMenuIzquierdo.Controls.OfType<Button>())
                {
                    menuButton.Text = "     " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void HabilitarControles()
        {
            switch (cacUsuario.Privilegio)
            {
                //Administrador
                case 1:
                    btnAfoElect.Enabled = true;
                    btnAfoObr.Enabled = true;
                    btnAfoSan.Enabled = true;
                    btnCertif.Enabled = true;
                    btnProfesionales.Enabled = true;
                    btnSupJer.Enabled = true;
                    btnUsuarios.Enabled = true;
                    btnConfig.Enabled = true;
                    VerificarAccesos();
                    break;

                //Rentas
                case 2:
                    btnAfoElect.Enabled = true;
                    VerificarAccesos();
                    break;

                //Obras Privadas
                case 3:
                    btnAfoElect.Enabled = true;
                    VerificarAccesos();
                    break;
            }
        }

        private void VerificarAccesos()
        {
            if (cacUsuario.AfConexElect)
            {
                ddmAfoElect.Enabled = true;
                pERMISOSToolStripMenuItem.Enabled = true;
                aFOROToolStripMenuItem.Enabled = true;
                cONSULTASToolStripMenuItem.Enabled = true;
            }
            if (cacUsuario.ConexElect)
            {
                ddmAfoElect.Enabled = true;
                pERMISOSToolStripMenuItem.Enabled = true;
                eNTREGANUEVOToolStripMenuItem.Enabled = true;
                cONSULTASToolStripMenuItem.Enabled = true;
            }            
        }
        #endregion

        #region Eventos
        private void panBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxRest_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEsconderMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void btnAfoElect_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(ddmAfoElect, sender);
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            Open_DropdownMenu(ddmUsuarios, sender);
        }

        private void Open_DropdownMenu(CDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev) => CDropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }

        private void CDropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctr)
        {
            CDropdownMenu dropdownMenu = (CDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                    ctr.BackColor = Color.FromArgb(159, 161, 224);
                else ctr.BackColor = Color.FromArgb(98, 102, 244);
            }
        }

        private void eNTREGANUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEntregaPermiso());
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNuevo());
        }

        private void cONSULTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Colapso el menu para tener mas espacio y mostrar todos los elementos
            if (this.panMenuIzquierdo.Width > 200) //Collapse menu
                CollapseMenu();            
            OpenChildForm(new frmConsultasAfElec());
        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Colapso el menu para tener mas espacio y mostrar todos los elementos
            if (this.panMenuIzquierdo.Width > 200) //Collapse menu
                CollapseMenu();
            OpenChildForm(new frmConsultaModif());
        }
        #endregion

        #region Arrastrar Formulario y Varios Adicionales
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //protected override void WndProc(ref Message m)
        //{
        //    const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
        //    const int WM_SYSCOMMAND = 0x0112;
        //    const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
        //    const int SC_RESTORE = 0xF120; //Restore form (Before)
        //    const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
        //    const int resizeAreaSize = 10;
        //    #region Form Resize
        //    // Resize/WM_NCHITTEST values
        //    const int HTCLIENT = 1; //Represents the client area of the window
        //    const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
        //    const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
        //    const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
        //    const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
        //    const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
        //    const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
        //    const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
        //    const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
        //    ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
        //    if (m.Msg == WM_NCHITTEST)
        //    { //If the windows m is WM_NCHITTEST
        //        base.WndProc(ref m);
        //        if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
        //        {
        //            if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
        //            {
        //                Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
        //                Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
        //                if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
        //                {
        //                    if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
        //                        m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
        //                    else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
        //                        m.Result = (IntPtr)HTTOP; //Resize vertically up
        //                    else //Resize diagonally to the right
        //                        m.Result = (IntPtr)HTTOPRIGHT;
        //                }
        //                else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
        //                {
        //                    if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
        //                        m.Result = (IntPtr)HTLEFT;
        //                    else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
        //                        m.Result = (IntPtr)HTRIGHT;
        //                }
        //                else
        //                {
        //                    if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
        //                        m.Result = (IntPtr)HTBOTTOMLEFT;
        //                    else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
        //                        m.Result = (IntPtr)HTBOTTOM;
        //                    else //Resize diagonally to the right
        //                        m.Result = (IntPtr)HTBOTTOMRIGHT;
        //                }
        //            }
        //        }
        //        return;
        //    }
        //    #endregion
        //    //Remove border and keep snap window
        //    if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
        //    {
        //        return;
        //    }
        //    //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
        //    if (m.Msg == WM_SYSCOMMAND)
        //    {
        //        /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
        //        /// Quote:
        //        /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
        //        /// are used internally by the system.To obtain the correct result when testing 
        //        /// the value of wParam, an application must combine the value 0xFFF0 with the 
        //        /// wParam value by using the bitwise AND operator.
        //        int wParam = (m.WParam.ToInt32() & 0xFFF0);
        //        if (wParam == SC_MINIMIZE)  //Before
        //            formSize = this.ClientSize;
        //        if (wParam == SC_RESTORE)// Restored form(Before)
        //            this.Size = formSize;
        //    }
        //    base.WndProc(ref m);
        //}
        #endregion        
    }
}
