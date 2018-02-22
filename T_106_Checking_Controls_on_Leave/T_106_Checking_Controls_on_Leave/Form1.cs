using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_106_Checking_Controls_on_Leave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("You must provide a name");
                textBox1.Select();

            }

        }
    }
}
