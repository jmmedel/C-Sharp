using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassspace;


namespace T_016_Namespace_And_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // pass the contrcutor arg 
            MyClass class1 = new MyClass("Kagaya");
            // calling the class.Name getter 
            MessageBox.Show(class1.Name);
        }
    }
}
