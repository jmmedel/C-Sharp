using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_097_Making_Controls
{
    public partial class Mybutton : UserControl
    {
        public Mybutton()
        {
            InitializeComponent();
        }
        string text = "";
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawButton(Color.FromKnownColor(KnownColor.Control));
        }

        public string ButtonText
        {
            get { return text; }
            set { text = value; }
        }

        private void Mybutton_MouseHover(object sender, EventArgs e)
        {
            Color mycolor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).R - 5, 255);
            DrawButton(mycolor);
        }

        void DrawButton(Color c)
        {
            SolidBrush s = new SolidBrush(c);
            Graphics g = this.CreateGraphics();
            g.FillRectangle(s, 0, 0, this.Width, this.Height);
            s.Color = Color.FromArgb(255, c.R - 13, c.G - 13, c.B - 13);
            g.FillRectangle(s, 0, this.Height / 2, this.Width, this.Height / 2);
            // PointF fpoint = new Point((this.Width / 2)- (label1.Width / 2), (this.Height / 2)-(label1.Height / 2));
            PointF fpoint = new Point((this.Width / 2) - (text.Length), (this.Height / 2) - (text.Length));
            FontFamily ff = new FontFamily("Arial");
            Font f = new System.Drawing.Font(ff, 8);
            s.Color = Color.Black;
            g.DrawString(text, f, s, fpoint);
        }

        private void Mybutton_MouseLeave(object sender, EventArgs e)
        {
            DrawButton(Color.FromKnownColor(KnownColor.Control));
        }

        private void Mybutton_MouseEnter(object sender, EventArgs e)
        {
            Color mycolor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).R - 5, 255);
            DrawButton(mycolor);
        }

        private void Mybutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
