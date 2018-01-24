using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_043_Split_And_To_ChartArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // using split methods
            string names = "kagaya;Bob;Joe;Steves;Allen;Matt";
            string[] nameArray = names.Split(';');
            foreach (var sm in nameArray)
            {
                MessageBox.Show(sm);
            }

            //tocharArray 
            string _letter = "abcdefg";
            char[] letter = _letter.ToCharArray();
            foreach (var item in letter)
            {
                MessageBox.Show(item.ToString());
            }

        }
    }
}
