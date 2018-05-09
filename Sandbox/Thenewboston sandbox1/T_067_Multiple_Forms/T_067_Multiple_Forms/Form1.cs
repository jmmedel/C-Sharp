using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_067_Multiple_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // go to the next forms 
            Form2 f = new Form2(textBox1.Text);
            f.Show();
            // you can only use 1 forms 
           // f.ShowDialog();
        }
    }
}
