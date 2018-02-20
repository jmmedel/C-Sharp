using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace T_095_LinearGradientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20, 20), new Point(70, 70), Color.Blue, Color.Yellow);
            Graphics g = panel1.CreateGraphics();
            g.FillEllipse(lgb, 20, 20, 100, 0);
            
        }
    }
}
