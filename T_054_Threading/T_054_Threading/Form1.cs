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
        private void button1_Click(object sender, EventArgs e)
        {   // start start the thread
          t = new Thread(Freeze);
            t.Start();
        }
        // Example to freeze for sake of teaching threading
        void Freeze()
        {
            for (; ; );
        }

        private void Form_Clossing(object sender, FormClosedEventArgs e)
        {   // abort 
            t.Abort();
        }
    }
}
