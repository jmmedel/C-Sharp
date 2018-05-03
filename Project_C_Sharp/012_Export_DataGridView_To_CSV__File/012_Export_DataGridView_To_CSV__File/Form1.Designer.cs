namespace _012_Export_DataGridView_To_CSV__File
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btmExport = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.storidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paytermsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleDataset = new _012_Export_DataGridView_To_CSV__File.SaleDataset();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.salesTableAdapter = new _012_Export_DataGridView_To_CSV__File.SaleDatasetTableAdapters.salesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // btmExport
            // 
            this.btmExport.Location = new System.Drawing.Point(466, 344);
            this.btmExport.Name = "btmExport";
            this.btmExport.Size = new System.Drawing.Size(75, 23);
            this.btmExport.TabIndex = 0;
            this.btmExport.Text = "Export";
            this.btmExport.UseVisualStyleBackColor = true;
            this.btmExport.Click += new System.EventHandler(this.btmExport_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 344);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(439, 23);
            this.progressBar.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(245, 370);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 12);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Processing 0%";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storidDataGridViewTextBoxColumn,
            this.ordnumDataGridViewTextBoxColumn,
            this.orddateDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.paytermsDataGridViewTextBoxColumn,
            this.titleidDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.salesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.Size = new System.Drawing.Size(529, 319);
            this.dataGridView.TabIndex = 3;
            // 
            // storidDataGridViewTextBoxColumn
            // 
            this.storidDataGridViewTextBoxColumn.DataPropertyName = "stor_id";
            this.storidDataGridViewTextBoxColumn.HeaderText = "stor_id";
            this.storidDataGridViewTextBoxColumn.Name = "storidDataGridViewTextBoxColumn";
            // 
            // ordnumDataGridViewTextBoxColumn
            // 
            this.ordnumDataGridViewTextBoxColumn.DataPropertyName = "ord_num";
            this.ordnumDataGridViewTextBoxColumn.HeaderText = "ord_num";
            this.ordnumDataGridViewTextBoxColumn.Name = "ordnumDataGridViewTextBoxColumn";
            // 
            // orddateDataGridViewTextBoxColumn
            // 
            this.orddateDataGridViewTextBoxColumn.DataPropertyName = "ord_date";
            this.orddateDataGridViewTextBoxColumn.HeaderText = "ord_date";
            this.orddateDataGridViewTextBoxColumn.Name = "orddateDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // paytermsDataGridViewTextBoxColumn
            // 
            this.paytermsDataGridViewTextBoxColumn.DataPropertyName = "payterms";
            this.paytermsDataGridViewTextBoxColumn.HeaderText = "payterms";
            this.paytermsDataGridViewTextBoxColumn.Name = "paytermsDataGridViewTextBoxColumn";
            // 
            // titleidDataGridViewTextBoxColumn
            // 
            this.titleidDataGridViewTextBoxColumn.DataPropertyName = "title_id";
            this.titleidDataGridViewTextBoxColumn.HeaderText = "title_id";
            this.titleidDataGridViewTextBoxColumn.Name = "titleidDataGridViewTextBoxColumn";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.saleDataset;
            // 
            // saleDataset
            // 
            this.saleDataset.DataSetName = "SaleDataset";
            this.saleDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackGroundWorker_Do_Work);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackGroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackGroundWorker_RunWorkerCompleted);
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 391);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btmExport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export DataGridView To CSV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmExport;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private SaleDataset saleDataset;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private SaleDatasetTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn storidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paytermsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleidDataGridViewTextBoxColumn;
    }
}

