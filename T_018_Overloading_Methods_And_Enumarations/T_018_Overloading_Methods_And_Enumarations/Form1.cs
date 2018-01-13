using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_018_Overloading_Methods_And_Enumarations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // use methods overloading with 2 arg
            // you can use the 1 arg methods
            MyClass.ShowMessage("Kagaya", 23);

            MyClass.ShowMessage("Kagaya");

            MyClass mc = new MyClass("John");
        }
    }
}
