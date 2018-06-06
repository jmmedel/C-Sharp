using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_028_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 
        private void button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.OnPropertyChanged += Mc_OnPropertyChanged;
            mc.Name = "Kagaya";
        }

        private void Mc_OnPropertyChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test the property has changed");
        }
    }
}
