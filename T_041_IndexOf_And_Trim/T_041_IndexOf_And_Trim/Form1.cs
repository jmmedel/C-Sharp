using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_041_IndexOf_And_Trim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string name = "John Seith";
            string firstName = name.Substring(0, name.IndexOf(' '));
            string Name = "        Kagaya          john";

            MessageBox.Show(firstName);
            // delete the space start trimstart
            // delete the space end trimend
            MessageBox.Show(Name.Trim());
        }

    }
}
