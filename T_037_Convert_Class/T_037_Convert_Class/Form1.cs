using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_037_Convert_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // you get and error if you put a letter on it 
            // because we are trting to convert by integer type
            // you can convert string type too or bool type
            try
            {
                int myint = Convert.ToInt32(textBox1.Text) + 2;
                MessageBox.Show(myint.ToString());
            }
            catch (Exception ex )
            {

                MessageBox.Show("you can put a letter on it");
            }
            

        }
    }
}
