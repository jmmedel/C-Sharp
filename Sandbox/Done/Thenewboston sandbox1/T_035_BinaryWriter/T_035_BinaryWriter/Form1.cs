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
namespace T_035_BinaryWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // using binarywriter
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(path));
            // you can write 
            //int myshort = 0x235466;
           // byte[] buffer = BitConverter.GetBytes(myshort);
           // Array.Reverse(buffer);
            bw.Write("C");
            
            bw.Dispose();
        }
    }
}
