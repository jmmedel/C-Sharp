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

        private void button2_Click(object sender, EventArgs e)
        {   // remove selected node
            // handle if its null 
            if(treeView1.SelectedNode == null)
            {
                return ;
            }
            treeView1.SelectedNode.Remove();
            // i dont like to use checkedbox to delete to the treeview
            // dont use it
           // RemoveSelectedNode(treeView1.Nodes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }
        List<TreeNode> tnlist = new List<TreeNode>();

        void RemoveSelectedNode(TreeNodeCollection tnc)
        {
            foreach  ( TreeNode item  in tnc)
            {
                if (item.Checked) tnlist.Add(item);
                else if (item.Nodes.Count != 0) RemoveSelectedNode(item.Nodes);
            }
            foreach (TreeNode item in tnlist)
            {
                treeView1.Nodes.Remove(item);
            }
        }

    }
}
