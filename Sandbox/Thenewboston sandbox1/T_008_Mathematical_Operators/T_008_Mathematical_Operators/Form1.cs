using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_008_Mathematical_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // easy mathematical operator 
            // + - * / % 
            //
            int a = 5;
            int b = 3;
            // in the method u need to use () to seperated to much () in this 1line
            MessageBox.Show("a + b = " + (a + b).ToString());
            MessageBox.Show("a - b = " + (a - b).ToString());
            MessageBox.Show("a * b = " + (a * b).ToString());
            MessageBox.Show("a / b = " + (a / b).ToString());
            MessageBox.Show("a % b = " + (a % b).ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // shorthand operator
            // ++ -- += -= *= /=
            // self explanatory
            int a = 5;
            int b = 3;
            a += 3;
            MessageBox.Show(a.ToString());
            // using -- prefix posfix ++
            int c = 10;
            MessageBox.Show("--C =" +(--c).ToString());
             c = 10;
            MessageBox.Show("C-- =" +(c--).ToString());
            // print again
            MessageBox.Show("C =" + (c).ToString());



        }
    }
}
