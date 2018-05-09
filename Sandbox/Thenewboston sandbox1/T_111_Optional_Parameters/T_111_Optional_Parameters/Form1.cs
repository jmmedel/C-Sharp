using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_111_Optional_Parameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // define it my there name = to the value
            ShowMessagebox(msg:"Kagaya");
        }
        void ShowMessagebox(string msg = "Hello world", string title = "Default value")
        {
            MessageBox.Show(msg,title);
        }
    }
}
