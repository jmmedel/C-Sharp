using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_006_More_on_If_Statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    // check if chcked
            // you can use ! for false
           

            if(checkBox1.Checked)
            {
                MessageBox.Show("The checkbox is cheeked");
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {    
            // you can use || piple line or && and 
            // to avoid using to much if nested statements 
            // make your  code clean 
            if(textBox1.Text == "Kagaya" && checkBox2.Checked)
            {
                MessageBox.Show("Hello","You passed");
            }
        }
    }
}
