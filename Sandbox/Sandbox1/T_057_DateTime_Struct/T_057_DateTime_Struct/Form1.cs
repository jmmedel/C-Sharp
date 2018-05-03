using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_057_DateTime_Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //using datetime 
            // im lazy im not doing nothing today
            DateTime dt = new DateTime(1993, 10, 16);
            MessageBox.Show(dt.ToString());

        }
    }
}
