using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_009_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // Array 
            string[] Names = { "Adam", "Bob" };
            // foreach you can access all in the array
            foreach (string s in Names) 
            {
                MessageBox.Show(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   // you can access to the aray[0] like this index 
            // Array start 0 index
            int[] numbers = { 555, 777, 444, 22 };
            MessageBox.Show(numbers[0].ToString());
        }
    }
}
