using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_Custom_Progress_Bar_With_Percentage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmStart_Click(object sender, EventArgs e)
        {
            my_ProgressBars1.Minimum = 0;
            my_ProgressBars1.Maximum = 100;
            for(int i = 0; i< 100; i++)
            {
                my_ProgressBars1.Value = i;
                Thread.Sleep(20);
            }
            
        }
    }
}
