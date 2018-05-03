using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_044_Math_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // using math libray
            label1.Text = Math.Abs(-4).ToString();
            label2.Text = Math.Pow(-4,2).ToString();
            label3.Text = Math.Tan(21).ToString();
            label4.Text = Math.Round(-4.12).ToString();
            label5.Text = Math.Sqrt(-4).ToString();
            label6.Text = Math.Truncate(-4.12).ToString();
        }
    }
}
