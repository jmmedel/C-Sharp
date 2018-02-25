using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace T_112_IEnumerable_And_Yield_Return
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Getnnumbers(0,10))
            {
                MessageBox.Show(item.ToString());
                //test ting 
            } 
        }

        IEnumerable Getnnumbers(int min, int max)
        {
            for (; min <= max; min++)
                yield return min;
        }
    }
}
