using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_070_ProgressBar_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // use it in block style progress bar
            // use performstep to not get and error
            //progressBar1.PerformStep();

            // next is marquee
            // if you dont know when is end 
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 100;

        }

        private void button2_Click(object sender, EventArgs e)
        {    // block style progress bar
            //progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Blocks;

        }
    }
}
