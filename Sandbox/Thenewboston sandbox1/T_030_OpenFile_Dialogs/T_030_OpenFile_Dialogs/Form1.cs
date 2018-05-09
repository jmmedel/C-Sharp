using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_030_OpenFile_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // give the filter and set only to png
            ofd.Filter = "PNG image | *.png";
            ofd.Title = "Open Image";
            if(ofd.ShowDialog() == DialogResult.OK)
            {   
                // get the filename of the file
                MessageBox.Show(ofd.SafeFileName);
            }

        }
    }
}
