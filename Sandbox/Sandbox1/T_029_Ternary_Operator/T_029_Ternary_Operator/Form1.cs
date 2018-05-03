using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_029_Ternary_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // using ternnary operator
            //string mystring = "";
            //if (checkBox1.Checked) mystring = "Its checked";
            //else mystring = "It not checked";
            // make 2 line of code 
            //string mystring = (checkBox1.Checked) ? "Its chekded" : "Not checked";
            // you can make it more 1 line of code but its hard to read;
            MessageBox.Show((checkBox1.Checked) ? "Its chekded" : "Not checked");
        }
    }
}
