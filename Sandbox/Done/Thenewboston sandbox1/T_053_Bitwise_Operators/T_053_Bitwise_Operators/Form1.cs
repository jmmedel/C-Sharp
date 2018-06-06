using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_053_Bitwise_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // invert bitwise operators
            short myShort = ~5;
            
            MessageBox.Show(Convert.ToString(myShort,2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            short myshort = 3 & 5; // 011 & 101 = 000001;
            MessageBox.Show(Convert.ToString(myshort,2));
            short myshort2 = 3 | 4;
            MessageBox.Show(Convert.ToString(myshort,2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            short myshort = 3 ^ 5; // 011 110
            MessageBox.Show(Convert.ToString(myshort,2));
        }

        private void button4_Click(object sender, EventArgs e)
        {   // you can use it >> or << to Shipp the bit
            short myShort = 3 >> 1;
            MessageBox.Show(Convert.ToString(myShort,2));
        }
    }
}
