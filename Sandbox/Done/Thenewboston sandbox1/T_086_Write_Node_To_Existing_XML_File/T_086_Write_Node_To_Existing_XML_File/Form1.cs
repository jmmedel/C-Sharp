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
namespace T_086_Write_Node_To_Existing_XML_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\kagaya\\Desktop\\Git\\T_086_Write_Node_To_Existing_XML_File\\T_086_Write_Node_To_Existing_XML_File\\Person.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode person = doc.CreateElement("Person");
            XmlNode name = doc.CreateElement("Name");
            name.InnerText = textBox1.Text;
            person.AppendChild(name);
            XmlNode age = doc.CreateElement("Age");
            age.InnerText = numericUpDown1.Value.ToString();
            person.AppendChild(age);
            XmlNode Email = doc.CreateElement("Email");
            Email.InnerText = textBox2.Text;
            person.AppendChild(Email);
            doc.DocumentElement.AppendChild(person);
            doc.Save(path);

        }
    }
}
