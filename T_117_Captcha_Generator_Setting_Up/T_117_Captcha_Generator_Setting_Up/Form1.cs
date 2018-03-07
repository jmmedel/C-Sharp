using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections.Generic;
namespace T_117_Captcha_Generator_Setting_Up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> String = new List<string>();
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
            byte[] buffer = new byte[randomString.Length];
            int y = 0;
            foreach (char c in randomString.ToCharArray())
            {
                buffer[y] = (byte)c;
                y++;
            }
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string md5string = BitConverter.ToString( md5.ComputeHash(buffer)).Replace("-","");
            String.Add(md5string);
            FontFamily ff = new FontFamily("Arial");
            Font f = new System.Drawing.Font(ff, 14);
            g.DrawString(randomString, f, b, 20, 20);
            for (int i = 0; i < 6; i++)
            {
                int j = ran.Next(0, 2);
                if (j == 0) g.DrawRectangle(p, ran.Next(0, 111), ran.Next(0, 60), ran.Next(0, 60), ran.Next(0, 60));
                else if (j == 1) g.DrawEllipse(p, ran.Next(0, 111), ran.Next(0, 60), ran.Next(0, 60), ran.Next(0, 60));
                p.Color = Color.FromArgb(0xFF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
            }
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
