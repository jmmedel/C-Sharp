using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_079_Accessing_All_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessAll(this.Controls);
        }
        // AccessAll control 
        void AccessAll(Control.ControlCollection cc)
        {
            foreach (Control item in cc)
            {   // this enabled all 
                //item.Enabled = false;
                if (item is Button)
                {
                    Button b = item as Button;
                    b.Click +=  new EventHandler(B_Click);
                }
                if(item.HasChildren)
                {
                    AccessAll(item.Controls);
                }
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you  click a button");
        }
    }
}
