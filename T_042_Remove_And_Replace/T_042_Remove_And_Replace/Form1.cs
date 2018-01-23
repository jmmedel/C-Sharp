using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_042_Remove_And_Replace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // remove string start with 0 index end if 7

            string sentence = "Hello, my name is john Hello ";
            string after = sentence.Remove(0,7);
            // using replace
            string replaceafter = sentence.Replace("Hello", "NIII");
            MessageBox.Show(after);
            MessageBox.Show(replaceafter);
        }
    }
}
