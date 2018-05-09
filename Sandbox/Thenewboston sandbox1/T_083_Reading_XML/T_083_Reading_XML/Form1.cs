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
namespace T_083_Reading_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            if(ofd.ShowDialog() == DialogResult.OK)
            {   // REad xml file 
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(ofd.FileName);
                // this is only see one file a times
                //MessageBox.Show(xDoc.SelectSingleNode("People/Person/Name").InnerText);
                foreach (XmlNode node in xDoc.SelectNodes("People/Person"))
                {
                    MessageBox.Show(node.SelectSingleNode("Name").InnerText);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {   // url here put the url 
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("");
            MessageBox.Show(xDoc.SelectSingleNode("People/Person/Name").InnerText);
        }
    }
}
