using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace T_032_StreamReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {   // read the file 
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                textBox1.Text = sr.ReadToEnd(); // read to end
                //sr.BaseStream.Position = 0xC;
                // byte[] buffer = new byte[3];
                // sr.BaseStream.Read(buffer, 0, 3);
                // foreach (byte mybte in buffer)
                //    textBox1.Text += mybte.ToString("X") + " ";
                // sr.Dispose();
                 

            }

        }
    }
}
