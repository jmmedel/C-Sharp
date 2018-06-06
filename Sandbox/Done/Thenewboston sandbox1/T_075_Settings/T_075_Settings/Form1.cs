using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_075_Settings
{
    public partial class Form1 : Form
    {
        public Form1()
        {   // this is where you need to put the setting
            //because this is where form create first call the constructor
            // think it like main where the program start fist
            InitializeComponent();
            textBox1.Text = T_075_Settings.Properties.Settings.Default.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            // click project 
            // project properties
            // go to setting
            // add string name
            T_075_Settings.Properties.Settings.Default.Name = textBox1.Text;
            T_075_Settings.Properties.Settings.Default.Save();
        }
    }
}
