using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace T_050_Path_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // Path_Class
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show(Path.GetDirectoryName(ofd.FileName));
            MessageBox.Show(Path.GetFileName(ofd.FileName));
            MessageBox.Show(Path.GetFileNameWithoutExtension(ofd.FileName));
            MessageBox.Show(Path.HasExtension(ofd.FileName).ToString());


        }
    }
}
