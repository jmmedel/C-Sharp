using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_076_TreeView_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // add Nodes
            treeView1.Nodes.Add("Person");
            treeView1.Nodes.Add("Programmer");
            // just like Array 0 index is person
            treeView1.Nodes[0].Nodes.Add("Kagaya");
            treeView1.Nodes[0].Nodes.Add("john");
            treeView1.Nodes[0].Nodes.Add("Medel");
            treeView1.Nodes[1].Nodes.Add("Kagaya");
            //add node inside the node
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Address");
        }
    }
}
