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
            if(Drawsquare)
            {
                SolidBrush s = new SolidBrush(toolStripButton1.ForeColor);
                g.FillRectangle(s, e.X, e.Y, Convert.ToInt32(toolStripTextBox2.Text), Convert.ToInt32(toolStripTextBox2.Text));
                cantPaint = false;
                Drawsquare = false;
            }
            else if (DrawRectangle)
            {
                SolidBrush s = new SolidBrush(toolStripButton1.ForeColor);
                g.FillRectangle(s, e.X, e.Y, Convert.ToInt32(toolStripTextBox2.Text) * 2, Convert.ToInt32(toolStripTextBox2.Text));
                cantPaint = false;
                DrawRectangle = false;
            }
            else if(DrawCircle)
            {
                SolidBrush s = new SolidBrush(toolStripButton1.ForeColor);
                g.FillRectangle(s, e.X, e.Y, 100, 50);
                cantPaint = false;
                DrawCircle = false;
            }
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
                Pen pen = new Pen(toolStripButton1.ForeColor, float.Parse(toolStripTextBox1.Text));
                g.DrawLine(pen, new Point(prex ?? e.X, prey ?? e.Y), new Point(e.X, e.Y));
                prex = e.X;
                prey = e.Y;
                
              
                
                
                
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                toolStripButton1.ForeColor = cd.Color;
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                toolStripButton3.ForeColor = cd.Color;
                panel1.BackColor = cd.Color;
            }
        }
        bool Drawsquare = false;
        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drawsquare = true;
        }
        bool DrawRectangle = false;
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawRectangle = true;
        }
        bool DrawCircle = false;
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawCircle = false;
        }
    }
}
