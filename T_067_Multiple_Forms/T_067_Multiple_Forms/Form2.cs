using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_067_Multiple_Forms
{
    public partial class Form2 : Form
    {
        public Form2(string mystring)
        {
            InitializeComponent();
            label1.Text = mystring;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
