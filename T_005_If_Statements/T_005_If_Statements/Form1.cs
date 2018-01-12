using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_005_If_Statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // using if statements 
            // you can use <> == != 

            if (textBox1.Text == "Kagaya")
            {
                MessageBox.Show("Hello");
            }
            else if (textBox1.Text == "Bob")
            {
                MessageBox.Show("Yo");
            }
            //
            else
                MessageBox.Show("Else");
        }
    }
}
