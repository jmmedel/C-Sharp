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
namespace T_115_Notified_When_Files_Change
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileSystemWatcher fsw = new FileSystemWatcher();
            fsw.Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
            fsw.Filter = "*.txt";
            fsw.Changed += new FileSystemEventHandler(Fsw_Changed);
            fsw.Renamed += new RenamedEventHandler(Fsw_Changed);
            fsw.EnableRaisingEvents = true;
        }

        private void Fsw_Changed(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("you have save a text file");
        }
        private void Fsw_Chaned(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("You have saved a text file");
        }
    }
}
