using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace T_087_Deleting_a_XML_NODE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("C:\\Users\\kagaya\\Desktop\\Git\\T_087_Deleting_a_XML_NODE\\T_087_Deleting_a_XML_NODE\\Person.xml");
            foreach (XmlNode xNode in xdoc.SelectNodes("People/Person"))
                if (xNode.SelectSingleNode("Name").InnerText == textBox1.Text)
                    xNode.ParentNode.RemoveChild(xNode);
            xdoc.Save("C:\\Users\\kagaya\\Desktop\\Git\\T_087_Deleting_a_XML_NODE\\T_087_Deleting_a_XML_NODE\\Person.xml");
        }
    }
}
