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
            List<DataSet1> list = ((dataParameter)e.Argument).productlist;
            string filename = ((dataParameter)e.Argument).filename;
            int index = 1;
            int process = list.Count;
            using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("ProductId,producname,price,stocks");
                 foreach(DataSet1 p in list)
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

        static DataSet1 db;
        protected static DataSet1 App
        {
            get
            {
                if (db == null)
                    db = new DataSet1();
                return db;
            }
        }

        struct dataParameter
        {
            public List<DataSet1> productlist;
            public string filename { get; set; }
        }
        dataParameter _inputparameter;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable1BindingSource.DataSource = db;
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
                    _inputparameter.productlist = dataTable1BindingSource.DataSource as List<DataSet1>;
                    _inputparameter.filename = sfd.FileName;
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;
                    backgroundWorker.RunWorkerAsync(_inputparameter);
                }
            }
        }
    }
}
