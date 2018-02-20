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
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush s = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
            Graphics g = this.CreateGraphics();
            g.FillRectangle(s, 0, 0, this.Width, this.Height);
            s.Color = Color.FromKnownColor(KnownColor.ControlLight);
            g.FillRectangle(s, 0, this.Height / 2, this.Width, this.Height / 2);
            label1.Location = new Point((this.Width / 2)- (label1.Width / 2), (this.Height / 2)-(label1.Height / 2));
        }

        public string ButtonText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

    }
}
