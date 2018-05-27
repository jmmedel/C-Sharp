using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_068_Multi_Document_Inteface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // this class from1
            this.IsMdiContainer = true;
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {   // minimize 
            this.LayoutMdi(MdiLayout.ArrangeIcons);
            this.LayoutMdi(MdiLayout.Cascade);
            this.LayoutMdi(MdiLayout.TileHorizontal);
            // vertical is posible
        }
    }
}
