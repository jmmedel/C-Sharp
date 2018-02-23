using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_108_Making_Conversion_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item i = (Item)3; // Explicit
            //Item item = 3; // implcit
            MessageBox.Show(i.Price.ToString());

        }
    }

    class Item
    {
        public int Price
        {
            get;
            set;
        }

        public static explicit operator Item(int itemprice)
        {
            Item i = new Item();
            i.Price = itemprice;
            return i;
        }
        /*
         public static implicit operator Item(int itemprice)
        {
            Item i = new Item();
            i.Price = itemprice;
            return i;
        }
         */


    }

}
