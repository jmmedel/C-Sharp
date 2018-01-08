using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_Export_DataGridView_To_CSV__File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BackGroundWorker_Do_Work(object sender, DoWorkEventArgs e)
        {   
            
            int index = 1;
            int process = salesBindingSource.Count;
            using (StreamWriter sw = new StreamWriter(new FileStream("gg", FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                
                foreach(object p in saleDataset.sales)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process);
                        sb.AppendLine(string.Format("nothing"));
                    }
                }
                sw.Write(sb.ToString());
            }
        }

        

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleDataset.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.saleDataset.sales);
           
            
        }

        private void BackGroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblStatus.Text = string.Format($"Processing ....{e.ProgressPercentage}% ");
            progressBar.Update();
        }

        private void BackGroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(1000);
            lblStatus.Text = "Your data has benn successfully exported";
        }

        private void btmExport_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;
                    backgroundWorker.RunWorkerAsync();
                }
            }
        }
    }
}
