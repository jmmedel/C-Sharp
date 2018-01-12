using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_014_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message("kagaya");
        }
        // methods you can use it over and over 
        // void no return type
        private void Message(string name)
        {
            MessageBox.Show("Hello Methods " + name);
        }

        private  int calculate(int x , int y)
        {   int sum = x + y;
            return sum;
        }
        private void button2_Click(object sender, EventArgs e)
        {   // you can call the methods over and over with deffirent arg
            Message("button2");
            MessageBox.Show(calculate(1, 2).ToString());
        }
    }
}
