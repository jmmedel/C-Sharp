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
using System.IO;
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
            Image[] image = new Image[amout];
            Random ran = new Random();
            for (int i = 0; i < amout; i++)
            {
                Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
                Graphics g = Graphics.FromImage(bitmap);
                g.Clear(panel1.BackColor);
                
                SolidBrush b = new SolidBrush(Color.FromArgb(0xFF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255)));
                Pen p = new Pen(Color.FromArgb(0xFF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255)));
                char[] chars = "qwertyuiopasdfghjklzxcvbnm1234567899".ToCharArray();
                string randomString = "";
                for (int d = 0; d < 6; d++)
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
                string md5string = BitConverter.ToString(md5.ComputeHash(buffer)).Replace("-", "");
                String.Add(md5string);
                FontFamily ff = new FontFamily("Arial");
                Font f = new System.Drawing.Font(ff, 14);
                g.DrawString(randomString, f, b, 20, 20);
                for (int z = 0; z < 6; z++)
                {
                    int j = ran.Next(0, 2);
                    if (j == 0) g.DrawRectangle(p, ran.Next(0, 111), ran.Next(0, 60), ran.Next(0, 60), ran.Next(0, 60));
                    else if (j == 1) g.DrawEllipse(p, ran.Next(0, 111), ran.Next(0, 60), ran.Next(0, 60), ran.Next(0, 60));
                    p.Color = Color.FromArgb(0xFF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
                }
                panel1.BackgroundImage = bitmap;
                image[i] = bitmap;
            }
            return image;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            generateCapcha(5);
            Image[] images = generateCapcha(Convert.ToInt32(textBox1.Text));
            int g = 0;
            foreach (Image item in images)
            {
                item.Save(label1.Text + "\\" + String[g] + ".png");
                g++;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label1.Text = fbd.SelectedPath;
            }
        }
        string md5hasname = "";
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                md5hasname = Path.GetFileNameWithoutExtension(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            int y = 0;
            byte[] buffer = new byte[textBox2.Text.Length];
            foreach (char c in textBox2.Text.ToCharArray())
            {
                buffer[y] = (byte)c;
            }
            string blah = BitConverter.ToString(md5.ComputeHash(buffer)).Replace("-", "");
            if(blah != md5hasname)
            {
                MessageBox.Show("You got it wrong");
            }
            else MessageBox.Show("You got it right");
        }
    }
}
