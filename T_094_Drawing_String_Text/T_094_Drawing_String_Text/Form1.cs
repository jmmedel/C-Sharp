using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_094_Drawing_String_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            SolidBrush s = new SolidBrush(Color.Blue);
            Graphics g = panel1.CreateGraphics();
            FontFamily ff = new FontFamily("Courier New");
            System.Drawing.Font font = new System.Drawing.Font(ff, 50);
            g.DrawString("Kagaya", font, s, new Point(20, 20));
        }
    }
}
