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
namespace T_048_Directory_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // testing any more control
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // using Directory class
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {   // get the file names
                 string [] filesPath = Directory.GetFiles(fbd.SelectedPath);
                foreach (string item in filesPath)
                {
                    MessageBox.Show(item);
                }
            }
        }

        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] FileDirectory = Directory.GetDirectories(fbd.SelectedPath);
                foreach (string item in FileDirectory)
                {
                    MessageBox.Show(item);
                }
            }
        }

        private void openDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] drivers = Directory.GetLogicalDrives();
            foreach(string s in drivers)
            {
                MessageBox.Show(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {   // Get the get creation time and return the date time
                MessageBox.Show(Directory.GetCreationTime(fbd.SelectedPath).ToString(),"GetCreationTime");
                // Get the last Access time 
                MessageBox.Show(Directory.GetLastAccessTime(fbd.SelectedPath).ToString(), "GetLastAccessTime");
                // get the write Access time
                MessageBox.Show(Directory.GetLastWriteTime(fbd.SelectedPath).ToString(),"GetlastWritetime");
                // GEt the parent
                MessageBox.Show(Directory.GetParent(fbd.SelectedPath).ToString(),"Getparent");


            }
        }
    }
}
