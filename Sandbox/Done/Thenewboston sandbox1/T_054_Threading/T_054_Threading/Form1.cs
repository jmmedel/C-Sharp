using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace T_054_Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread t;
        string mystring = "";
        private void button1_Click(object sender, EventArgs e)
        {   // start start the thread
             t = new Thread(Write);
             t.Start();
            while (t.IsAlive) ;
             textBox1.Text = mystring;
        }
        // Example to freeze for sake of teaching threading
        void Write()
        {
            for(int i = 0; i < 1000; i++)
            {
                mystring += "Kagaya" + i.ToString() + "\r\n";
            }
        }

        private void Form_Clossing(object sender, FormClosedEventArgs e)
        {   // abort 
            t.Abort();
        }

    }
}
