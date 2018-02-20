using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_096_Paint_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }
        bool cantPaint = false;
        Graphics g;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            cantPaint = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            cantPaint = false;
            prex = null;
            prey = null;
        }
        int? prex = null;
        int? prey = null;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if(cantPaint)
            {
                Pen pen = new Pen(Color.Black, float.Parse(toolStripTextBox1.Text));
                g.DrawLine(pen, new Point(prex ?? e.X, prey ?? e.Y), new Point(e.X, e.Y));
                prex = e.X;
                prey = e.Y;
                
              
                
                
                
            }

        }
    }
}
