using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_038_Special_Folder_Locations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // convert bool type true or false only
            try
            {
                bool myBool = Convert.ToBoolean(textBox1.Text);
                MessageBox.Show(myBool.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show("The conversion failed");
            }
           
         
        }
    }
}
