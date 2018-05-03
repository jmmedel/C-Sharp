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
namespace T_049_File_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // open fileDialog
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show(File.Exists(ofd.FileName).ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // delete file
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                File.Delete(ofd.FileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                // this is my directory change it to use it 
                File.Copy(ofd.FileName, "C:\\Users\\kagaya\\Desktop\\GG\\textnew.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                // this is my directory change it to use it 
                File.Move(ofd.FileName, "C:\\Users\\kagaya\\Desktop\\GG\\newtext\\textnew.txt");
        }
    }
}
