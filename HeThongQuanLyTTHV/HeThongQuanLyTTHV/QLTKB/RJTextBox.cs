using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyTTHV.QLTKB
{
    public partial class RJTextBox : UserControl
    {
        private int borderSize = 1;
        private Color borderColor = Color.MediumVioletRed;
        private bool underlineStyle = false;

        public RJTextBox()
        {
            InitializeComponent();
        }

        [Category("Custom TextBox_Digit")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom TextBox_Digit")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom TextBox_Digit")]
        public bool UnderlineStyle 
        { 
            get => underlineStyle;
            set
            {
                underlineStyle = value;
                this.Invalidate();
            }
        }

        [Category("Custom TextBox_Digit")]
        public string Texts
        {
            get => textBoxDigit.Text;
            set => textBoxDigit.Text = value;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = PenAlignment.Inset;
                if (underlineStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateHeight();
        }

        private void UpdateHeight()
        {
            if(textBoxDigit.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBoxDigit.Multiline = true;
                textBoxDigit.MinimumSize = new Size(0, txtHeight);
                textBoxDigit.Multiline = false;
                this.Height = textBoxDigit.Height + this.Padding.Top + this.Padding.Bottom;
            }    
        }

        private void TextBoxDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập vào 1 số!");
            }
        }
    }
}
