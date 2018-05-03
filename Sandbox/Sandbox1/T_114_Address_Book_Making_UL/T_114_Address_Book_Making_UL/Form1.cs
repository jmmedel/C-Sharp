using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace T_114_Address_Book_Making_UL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // part 170 
        List<Person> people = new List<Person>();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = textBox1.Text;
            p.streeAddress = textBox3.Text;
            p.Email = textBox2.Text;
            p.Birthday = dateTimePicker1.Value.ToString();
            p.AdditionaNotes = textBox4.Text;
            people.Add(p);
            listView1.Items.Add(p.Name);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            remove();
        }

        void remove()
        {
            try
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                people.RemoveAt(listView1.SelectedItems[0].Index);
            }
            catch (Exception)
            {

                throw;
            }
            

        }
        class Person {
            
            public string Name
            {
                get;
                set;
            }
            public string streeAddress
            {
                get;
                set;
            }

            public string Email
            {
                get;
                set;
            }
            public string AdditionaNotes
            {
                get;
                set;
            }
            public string Birthday
            {
                get;
                set;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\Address Book - kagaya")) ;
                 Directory.CreateDirectory(path + "\\Address Book - kagaya");
            if (!File.Exists(path + "\\Address Book - kagaya\\setting.xml")) ;
                File.Create(path + "\\Address Book - kagaya\\setting.xml");

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = people[listView1.SelectedItems[0].Index].Name;
            textBox2.Text = people[listView1.SelectedItems[0].Index].Email;
            textBox3.Text = people[listView1.SelectedItems[0].Index].streeAddress;
            textBox4.Text = people[listView1.SelectedItems[0].Index].AdditionaNotes;
            dateTimePicker1.Value = DateTime.Now;



        }
    }// end of class

}
