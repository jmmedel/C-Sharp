﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_015_Continue_And_Break
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // break keywords
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) break;
                textBox1.Text += i.ToString();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {    // continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 2) continue;
                textBox1.Text += i.ToString();

            }
        }
    }
}
