using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_045_Generating_Random_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // using ramdom 
            Random r = new Random();
            label1.Text = r.Next(1,10).ToString();
            label2.Text = r.Next(1, 10).ToString();
            label3.Text = r.Next(1, 10).ToString();
            label4.Text = r.Next(1, 10).ToString();
            label5.Text = r.Next(1, 10).ToString();
            label6.Text = r.Next(1, 10).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {   // using binary
            byte[] buffer = new byte[5];
            Random r = new Random();
            r.NextBytes(buffer);
            
            label1.Text = BitConverter.ToString(buffer);
            label2.Text = BitConverter.ToString(buffer);
            label3.Text = BitConverter.ToString(buffer);
            label4.Text = BitConverter.ToString(buffer);
            label5.Text = BitConverter.ToString(buffer);
            label6.Text = BitConverter.ToString(buffer);

        }
    }
}
