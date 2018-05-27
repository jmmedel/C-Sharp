using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_077_TreeView_Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode();
            tn.Text = "Person";
            tn.ImageIndex = 3;
            tn.SelectedImageIndex = 3;
            treeView1.Nodes.Add(tn);
            TreeNode t= new TreeNode();
            t.Text = "programmer";
            t.ImageIndex = 0;
            t.SelectedImageIndex = 0;
            treeView1.Nodes.Add(t);
        }
    }
}
