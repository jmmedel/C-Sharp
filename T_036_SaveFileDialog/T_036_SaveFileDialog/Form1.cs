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
namespace T_036_SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // save the read and save file
            SaveFileDialog sfd = new SaveFileDialog();
            // you can create a filtter
            sfd.Filter = "Text File | *.txt";
            sfd.FileName = "My Text File";
            sfd.Title = "Save text File";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                BinaryWriter bw = new BinaryWriter(File.Create(path));
                bw.Write("Example text file");
                bw.Dispose();
            }
           
            
        }
    }
}
