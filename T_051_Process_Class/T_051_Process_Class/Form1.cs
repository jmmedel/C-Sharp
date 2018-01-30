using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace T_051_Process_Class
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
            if (ofd.ShowDialog() == DialogResult.OK) ;
            {   //start the program
                Process.Start(ofd.FileName);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Process.GetCurrentProcess().ProcessName);
        }

        private void button4_Click(object sender, EventArgs e)
        {   // kill the process() 
            Process.GetCurrentProcess().Kill();
        }
    }
}
