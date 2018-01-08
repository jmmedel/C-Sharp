namespace _017_Search_DataGridView_Using_ComboBox_And_TxtBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbColumn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.storidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paytermsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleData = new _017_Search_DataGridView_Using_ComboBox_And_TxtBox.SaleData();
            this.salesTableAdapter = new _017_Search_DataGridView_Using_ComboBox_And_TxtBox.SaleDataTableAdapters.salesTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column";
            // 
            // cbColumn
            // 
            this.cbColumn.FormattingEnabled = true;
            this.cbColumn.Items.AddRange(new object[] {
            "stor_id",
            "ord_num",
            "ord_date",
            "qty",
            "payterms",
            "title_id"});
            this.cbColumn.Location = new System.Drawing.Point(72, 32);
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Size = new System.Drawing.Size(218, 20);
            this.cbColumn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storidDataGridViewTextBoxColumn,
            this.ordnumDataGridViewTextBoxColumn,
            this.orddateDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.paytermsDataGridViewTextBoxColumn,
            this.titleidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(493, 309);
            this.dataGridView1.TabIndex = 4;
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
            this.salesBindingSource.DataSource = this.saleData;
            // 
            // saleData
            // 
            this.saleData.DataSetName = "SaleData";
            this.saleData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(354, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 19);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_keydown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 399);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbColumn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SaleData saleData;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private SaleDataTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn storidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paytermsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

