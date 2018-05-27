using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_007_Switch_Statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // using switch very usefull
           // it can avoid using to much if make more simple
           // all code inside in switch block easy to maintain the code
           // you can use in deffirent type like integer 
           switch(textBox1.Text)
            {
                case "Kagaya":
                    MessageBox.Show("Hello kagaya");
                    break;
                case "John":
                    MessageBox.Show("Heeloo john");
                    break;
               
                default :
                    MessageBox.Show("Your name is'nt imported");
                    break;
            }
        }
    }
}
