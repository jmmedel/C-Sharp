using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_061_ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // colordialog
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = false;
            cd.ShowHelp = true;
            cd.HelpRequest += new EventHandler(cd_helpRequest);
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                button1.BackColor = cd.Color;
        }

        private void cd_helpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a color for a the background button");
        }

    }
}
