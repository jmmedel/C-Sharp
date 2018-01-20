using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_040_Substrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // using substring 
            string Name = "John Medel";
            // start with 0 index and get 4 letter
            string LastName = Name.Substring(0,4);
            MessageBox.Show(LastName.ToString());
        }
    }
}
