using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Ref_And_Out_Keywords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Age = 3;
            string name;
            Modify(Age);
            MessageBox.Show(Age.ToString());
            // like fuction pointer
            RefModify(ref Age);
            outModify(ref Age, out name);
            MessageBox.Show(Age.ToString() + name);

        }
        // using ref 
        // like c++ fuction pointer
        void RefModify( ref int age)
        {
            age += 5;
        }
        void outModify(ref int age,out string Name)
        {   
            age += 5;
            Name = "New name";
        }
        void Modify(int age)
        {
            age += 5;
        }
    }
}
