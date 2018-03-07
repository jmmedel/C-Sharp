using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_119_ICloneable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mynames = "adam";
            string clone = (string)mynames.Clone();
            MessageBox.Show(clone);
            Myclass mc = new Myclass();
            mc.Name = "Kagaya";
            Myclass cloneclass = (Myclass)mc.Clone();
            MessageBox.Show(cloneclass.Name);
        }

    }

    class Myclass : ICloneable
    {

        public string Name
        {
            get;
            set;
        }

        public object Clone()
        {
            return this;
        }
    }
}
