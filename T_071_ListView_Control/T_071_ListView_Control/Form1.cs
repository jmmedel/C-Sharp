using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_071_ListView_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // make a check if empty or null
            // part 3 tomorrow
            ListViewItem item1;
            
                item1 = new ListViewItem(textBox1.Text);
                item1.SubItems.Add(textBox3.Text);
                item1.SubItems.Add(textBox2.Text);
                listView1.Items.Add(item1);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
          

        }

        private void getNameofItemToolStripMenuItem_Click(object sender, EventArgs e)
        {   // using contentmenustrip 
            // rightclick 
            if(listView1.SelectedItems.Count != 0)
            {
                MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
            }
        }
    }
}
