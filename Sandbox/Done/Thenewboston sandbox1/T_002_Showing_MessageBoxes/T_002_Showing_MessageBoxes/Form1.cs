using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_002_Showing_MessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // this is how to Messagebox
            MessageBox.Show("This is text for messageBox ","Error");
        }
        // you can see all the Event for button
        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are Hover your mouse over the button");
        }
    }
}
