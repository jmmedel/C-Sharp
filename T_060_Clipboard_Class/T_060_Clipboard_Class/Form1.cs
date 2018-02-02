using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_060_Clipboard_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\kagaya\\Downloads\\2018\\image\\Visual Studio 2013 Image Library\\2010_VS Icon Legacy\\Icons - VS2010\\2(two)columns_9708_32.bmp";

        }

        private void button1_Click(object sender, EventArgs e)
        {   // clipboard is somethinbg get copy 
            // may usefull hacking like somebody copy or copy paste something

            textBox2.Text = Clipboard.GetText();

            // copy image use clipboard
            pictureBox2.Image = Clipboard.GetImage();

            
        }
    }
}
