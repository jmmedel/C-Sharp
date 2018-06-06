using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_003_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // this is string name;
            string name = "Kagaya";
            // this is integer;
            int age = 23;
            // bool type true or false
            bool redhaird = false;
            // object  can hold any type 
            object myobj = 21;
            object myobj2 = "21";
            object myobj3 = false;

            // this is how to pass varible to the function of messagebox;
            // you  can convert using Tostring method
            MessageBox.Show($"{name} is {age} years old and my hair is black {redhaird.ToString()}");
            MessageBox.Show($" myobj = {myobj.GetType()} myobj2 = {myobj2.GetType()} myobj3 = {myobj3.GetType()}");
        }
    }
}
