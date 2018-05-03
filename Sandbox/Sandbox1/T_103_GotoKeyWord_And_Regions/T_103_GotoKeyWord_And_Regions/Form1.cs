using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_103_GotoKeyWord_And_Regions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using region 
            #region goto
            // go to is bad to use
            string Name = "Kagaya";
            switch(Name)
            {
                case "Hello":
                    MessageBox.Show("Hello");
                    break;
                default:
                    MessageBox.Show("the Default");
                    // jump to the Hello
                    goto case "Hello";
                    goto MYCode;
            }
            // use goto 
            MYCode:
            {
                MessageBox.Show("Go to");
            }

            #endregion
        }
    }
}
