using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_078_Property_Grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Person p = new Person();
        private void button1_Click(object sender, EventArgs e)
        {
            p.Name = "Kagaya";
            p.Age = 24;
            p.Email = "jmkagayagmail.com";
            // using property grid
            propertyGrid1.SelectedObject = p;
            Reload();
        }
        void Reload()
        {
            textBox1.Text = p.Name;
            textBox2.Text = p.Age.ToString();
            textBox3.Text = p.Email;

        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Reload();

        }

    }
}
