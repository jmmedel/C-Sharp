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
namespace T_085_Writing_New_XMl_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // you can use openfile dialog here but im to lazy to that know 
            string path = "C:\\Users\\kagaya\\Desktop\\Git\\T_085_Writing_New_XMl_File\\T_085_Writing_New_XMl_File\\Person.xml";
            XmlTextWriter xwriter = new XmlTextWriter(path, Encoding.UTF8);
            xwriter.Formatting = Formatting.Indented;
            xwriter.WriteStartElement("People");//<People>
            xwriter.WriteStartElement("Person");// <Person>
            xwriter.WriteStartElement("Name"); // <Name>
            xwriter.WriteString(textBox1.Text); //Textbox1.Text
            xwriter.WriteEndElement();//</Name>
            xwriter.WriteStartElement("Age");//<Age>
            xwriter.WriteString(numericUpDown1.Value.ToString());
            xwriter.WriteEndElement();//</Age>
            xwriter.WriteStartElement("Email");//<Email>
            xwriter.WriteString(textBox2.Text);
            xwriter.WriteEndElement();//</Email>
            xwriter.WriteEndElement();//</Person>
            xwriter.WriteEndElement();//</People>
            xwriter.Close();


        }
    }
}
