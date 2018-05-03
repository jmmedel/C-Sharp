using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_118_Reading_And_Writing_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //186
        // 197
        private void button1_Click(object sender, EventArgs e)
        {
            Myclass c = new Myclass();
        }
    }

    class Myclass
    {
        public Myclass()
        {
            MessageBox.Show("Im am the ctor.");
        }

        ~Myclass()
        {
            MessageBox.Show("I am the destructor");
        }

    }

}
