using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_004_Changing_Properties_With_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // you can change the properties of a componets 
            button1.Text = "NEW_Button";
            // enabled the button
            // you cann see all the properties of componetds 
            // in . seperator intelesences play a round
            button1.Enabled = false;
            textBox1.Text = "Kagaya";
        }
    }
}
