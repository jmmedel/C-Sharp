using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_Calculator
{
    public partial class Form1 : Form
    {
        double value;
        string soperator;
        bool check;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void Plumber(object sender, EventArgs e)
        {
            if ((soperator == "+") || (soperator == "-") || (soperator == "*") || (soperator == "/")) ;
            {
                if(check)
                {
                    check = false;
                    texResult.Text = "0";

                }
            }
            Button b = sender as Button;
            if (texResult.Text == "0")
                texResult.Text = b.Text;
            else
                texResult.Text += b.Text;
        }
        private void Poperator(object sender, EventArgs e)
        {
            Button b = sender as Button;
            value = double.Parse(texResult.Text);
            soperator = b.Text;
            texResult.Text += b.Text;
            check = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            texResult.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            texResult.Text = "0";
            value = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                switch(soperator)
                {
                    case "+":
                        texResult.Text = (value + double.Parse(texResult.Text)).ToString();
                        break;
                    case "-":
                        texResult.Text = (value - double.Parse(texResult.Text)).ToString();
                        break;
                    case "*":
                        texResult.Text = (value * double.Parse(texResult.Text)).ToString();
                        break;
                    case "/":
                        texResult.Text = (value / double.Parse(texResult.Text)).ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
