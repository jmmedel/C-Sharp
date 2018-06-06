using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_Phone_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                App.PhoneBook.AddPhoneBookRow(App.PhoneBook.NewPhoneBookRow());
                phoneBookBindingSource.MoveLast();
                txtPhoneNumber.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.PhoneBook.RejectChanges();
            }
        }

        private void btmEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtPhoneNumber.Focus();
        }

        private void btmcancel_Click(object sender, EventArgs e)
        {
            phoneBookBindingSource.ResetBindings(false);
            panel1.Enabled = false;
        }

        private void btmSave_Click(object sender, EventArgs e)
        {   try
            {
                phoneBookBindingSource.EndEdit();
                App.PhoneBook.AcceptChanges();
                App.PhoneBook.WriteXml(string.Format($"{Application.StartupPath}//data.dat"));
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.PhoneBook.RejectChanges();
            }
        }
        static AppData db;
        protected static AppData App
        {
            get
            {
                if (db == null)
                    db = new AppData();
                return db;
            }
        }

        // main Form
        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = string.Format($"{Application.StartupPath}//data.dat");
            if (File.Exists(fileName))
                App.PhoneBook.ReadXml(fileName);
            phoneBookBindingSource.DataSource = App.PhoneBook;
            panel1.Enabled = false;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                    phoneBookBindingSource.RemoveCurrent();
            }
        }

        private void txtSearch_Keypress(object sender, KeyPressEventArgs e)
        {   if (e.KeyChar == (char)13)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    var querys = from o in App.PhoneBook
                                 where o.PhoneNumber == txtSearch.Text || o.FullName.Contains(txtSearch.Text) || o.Email == txtSearch.Text
                                 select o;
                    dataGridView1.DataSource = querys.ToList();
                }
                else
                    dataGridView1.DataSource = phoneBookBindingSource;
            }
        }
    }
}
