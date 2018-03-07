using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_117_Captcha_Generator_Setting_Up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image[] generateCapcha(int amout)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            Random ran = new Random();
            SolidBrush b = new SolidBrush(Color.FromArgb(0xFF,ran.Next(0,255), ran.Next(0, 255), ran.Next(0, 255)));
            Pen p = new Pen(Color.FromArgb(0xFF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255)));
            char[] chars = "qwertyuiopasdfghjklzxcvbnm1234567899".ToCharArray();
            string randomString = "";
            for (int i = 0; i < 6; i++)
            {
                randomString += chars[ran.Next(0, 35)];
            }
            FontFamily ff = new FontFamily("Arial");
            Font f = new System.Drawing.Font(ff, 14);
            g.DrawString(randomString, f, b, 20, 20);
            return null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            generateCapcha(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
