using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_069_Combo_Box_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // style of combo box on properties
            // you can change to dropdownlis to not to change 
            // simple just put all  the item inside of it
            // you can add collection or item in the combox
           
            
            if (comboBox1.Text == "Kagaya")
            {
                MessageBox.Show("Yes its kagaya");
            }
            else
                MessageBox.Show("Pick on the combox1 else ");
            comboBox1.Items.Add("GG");
            MessageBox.Show(comboBox1.Items.Count.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   // indexchanged
            MessageBox.Show("Test");
        }
    }
}
