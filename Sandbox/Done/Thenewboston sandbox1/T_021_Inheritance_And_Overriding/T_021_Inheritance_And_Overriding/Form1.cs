using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_021_Inheritance_And_Overriding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MysecondClass msc = new MysecondClass();
            //msc.ShowMessage("Message");
            msc.overideshowmessage("Message");

            
        }
    }
}
