using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_024_Structs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client1 = new Client();
            client1.Name = "Kagaya";
            client1.Age = 24;
            Client client2 = new Client();
            client2.Name = "Joe";
            client2.Age = 12;

        }
    }
}
