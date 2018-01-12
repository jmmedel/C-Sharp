using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_010_Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    // generic type of list string
            List<String> Names = new List<string>();
            Names.Add("Kagaya");
            Names.Add("John");
            MessageBox.Show(Names[0]);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // list integer
            List<int> number = new List<int>();
            number.Add(5);
            number.Add(4);
            MessageBox.Show(number[0].ToString());

        }
    }
}
