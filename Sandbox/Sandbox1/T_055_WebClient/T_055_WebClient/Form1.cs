using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace T_055_WebClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadEvent(object sender, EventArgs e)
        {   //
            WebClient wc = new WebClient();
            // put the url
            textBox1.Text = wc.DownloadString("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {   // put the url
                WebClient wc = new WebClient();
                wc.DownloadFileAsync(new Uri(""), sfd.FileName);
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
            }
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            label2.Text = "Progress:" + e.ProgressPercentage.ToString();
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("The file is downloaded");
        }

    }
}
