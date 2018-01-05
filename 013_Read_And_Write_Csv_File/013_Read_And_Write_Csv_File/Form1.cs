using CsvHelper;
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
// need to download Csv helper 
namespace _013_Read_And_Write_Csv_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmWrite_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        var writer = new CsvWriter(sw);
                        writer.WriteHeader(typeof(Student));
                        foreach(Student s in studentBindingSource.DataSource as List<Student>)
                        {
                            writer.WriteRecord(s);
                        }
                    }
                    MessageBox.Show("Your Data has Been Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btmRead_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    var csv = new CsvReader(sr);
                    studentBindingSource.DataSource = csv.GetRecords<Student>();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = new List<Student>();

        }
    }
}
