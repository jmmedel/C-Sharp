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
            {   // get the o index only
                // MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
                // get all the item selected
                // [0] full name 
                // [1] is age
                // [2] Email
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    MessageBox.Show(item.SubItems[0].Text);
                }
            }
        }

        private void removeSelectedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count != 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    item.Remove();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   // button to remove
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (item.Checked) { item.Remove(); }
                
            }
        }

        private void removeAllItemToolStripMenuItem_Click(object sender, EventArgs e)
        {   // remove all
            listView1.Items.Clear();
        }
    }
}
