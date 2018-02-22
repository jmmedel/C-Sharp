using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// its public now to accces it
using MyDLL.Client;
namespace T_101_Internal_Access_Modifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            // cant accest to the c.name because its interna
            //c.Name
            
        }
    }
}
