using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_093_Drawing_With_Pen_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red,3);
            Graphics g = panel1.CreateGraphics();
            g.DrawRectangle(pen, 20, 20, 50, 50);
            g.DrawEllipse(pen, 50, 50, 50, 50);
            
        }
    }
}
