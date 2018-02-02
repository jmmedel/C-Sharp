using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_064_Timer_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // you can use it to troll some body in hacking if you
            // dont put timer.stop 
            
            //timer1.Stop();
            MessageBox.Show("Hello");
            textBox1.Text += i++.ToString();
        }
    }
}
