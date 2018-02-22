using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Addding Mydll class criented
using MyDLL.Client;
namespace T_100_Making_DLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // this is mydll class
            
            Client c = new Client();
            c.name = "Kagaya";
            MessageBox.Show(c.name);
        }
    }
}
