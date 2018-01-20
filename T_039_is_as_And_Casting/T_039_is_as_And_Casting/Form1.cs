using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_039_is_as_And_Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // casting
            // obj is univerlsal object type i can be any type
            object myobj = "Kagaya";
            Control myControl = button1;
            if (myobj is string) MessageBox.Show("myobj is a string True");
            if (myControl is Button)
            {
                //Button mybutton = (Button)myControl; // using as a casting
                Button mybutton = myControl as Button; // simple way to cast
                MessageBox.Show(mybutton.Text);
            }
        }

    }
}
