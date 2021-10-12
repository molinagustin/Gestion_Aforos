using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CPresentacion.ControlesPersonalizados
{
    [DefaultEvent("_TextChanged")]
    public partial class txtExterior : UserControl
    {        
        //Campos
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;

        //Constructor
        public txtExterior()
        {
            InitializeComponent();
        }

        //Eventos
        public event EventHandler _TextChanged;

        //Propiedades
        public Color BorderColor
        {
            get => borderColor; set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public Color BorderFocusColor
        {
            get => borderFocusColor; set
            {
                borderFocusColor = value;
            }
        }

        public int BorderSize
        {
            get => borderSize; set
            {
                if (value >= 1)
                {
                    borderSize = value;
                    this.Invalidate();
                }
                
            }
        }

        public bool UnderlinedStyle
        {
            get => underlinedStyle; set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                {
                    txtInterior.UseSystemPasswordChar = value;
                }
            }
        }     

        public bool Multiline
        {
            get { return txtInterior.Multiline; }
            set { txtInterior.Multiline = value; }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                txtInterior.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                txtInterior.ForeColor = value;
            }
        }

        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                txtInterior.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        public string Texts
        {
            get { if (isPlaceholder) return "";
                else return txtInterior.Text;
            }
            set { txtInterior.Text = value;
                SetPlaceholder();
            }
        }
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }

        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                    txtInterior.ForeColor = value;
            }
        }

        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                txtInterior.Text = "";
                SetPlaceholder();
            }
        }

        //Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;//Set Border color in focus. Otherwise, normal border color

                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        //Private methods
        private void UpdateControlHeight()
        {
            if (txtInterior.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                txtInterior.Multiline = true;
                txtInterior.MinimumSize = new Size(0, txtHeight);
                txtInterior.Multiline = false;

                this.Height = txtInterior.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txtInterior.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                txtInterior.Text = placeholderText;
                txtInterior.ForeColor = placeholderColor;
                if (isPasswordChar)
                    txtInterior.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                txtInterior.Text = "";
                txtInterior.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    txtInterior.UseSystemPasswordChar = true;
            }
        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(txtInterior.ClientRectangle, borderRadius - borderSize);
                txtInterior.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(txtInterior.ClientRectangle, borderSize * 2);
                txtInterior.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }

        //TextBox events
        private void txtInterior_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void txtInterior_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void txtInterior_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void txtInterior_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void txtInterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void txtInterior_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void txtInterior_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
    }
}
