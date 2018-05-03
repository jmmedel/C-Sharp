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

        private void button5_Click(object sender, EventArgs e)
        {   // get all the process name
            foreach (Process p in Process.GetProcesses())
            {
                // MessageBox.Show(p.ProcessName);
                MessageBox.Show(p.Responding.ToString());
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {   // kill all the program not responding 
            foreach (Process p in Process.GetProcesses())
            {
                if(!p.Responding)
                {
                    p.Kill();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach(Process p in Process.GetProcessesByName("Skype"))
                MessageBox.Show(p.ProcessName);
        }
    }
}
