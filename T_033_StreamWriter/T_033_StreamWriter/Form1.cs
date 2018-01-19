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
namespace T_033_StreamWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {   // ebabled the button 2 if they open file
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   // openwrite just write
            // file.create delete all file  inside that file
            //
            StreamWriter sw = new StreamWriter(File.OpenWrite(path));
            //writeline next line
            sw.WriteLine(textBox1.Text);
            //sw.BaseStream.Position = 0x28;
            //byte[] buffer = { 0x00, 0x09, 0x0A };
            //sw.BaseStream.Write(buffer, 0, 3);
            sw.Dispose();
        }
    }
}
