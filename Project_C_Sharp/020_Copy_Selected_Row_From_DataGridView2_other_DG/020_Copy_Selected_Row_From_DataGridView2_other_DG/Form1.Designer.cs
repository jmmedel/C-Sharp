namespace _020_Copy_Selected_Row_From_DataGridView2_other_DG
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
            this.btmLeft = new System.Windows.Forms.Button();
            this.dataGridViewLeft = new System.Windows.Forms.DataGridView();
            this.btm_Right = new System.Windows.Forms.Button();
            this.dataGridViewRight = new System.Windows.Forms.DataGridView();
            this.kagayaDataSet = new _020_Copy_Selected_Row_From_DataGridView2_other_DG.kagayaDataSet();
            this.kagayaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new _020_Copy_Selected_Row_From_DataGridView2_other_DG.kagayaDataSetTableAdapters.salesTableAdapter();
            this.storidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeftSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRightSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paytermsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kagayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kagayaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btmLeft
            // 
            this.btmLeft.Location = new System.Drawing.Point(329, 199);
            this.btmLeft.Name = "btmLeft";
            this.btmLeft.Size = new System.Drawing.Size(38, 23);
            this.btmLeft.TabIndex = 0;
            this.btmLeft.Text = "<<";
            this.btmLeft.UseVisualStyleBackColor = true;
            this.btmLeft.Click += new System.EventHandler(this.btmLeft_Click);
            // 
            // dataGridViewLeft
            // 
            this.dataGridViewLeft.AllowUserToAddRows = false;
            this.dataGridViewLeft.AllowUserToDeleteRows = false;
            this.dataGridViewLeft.AutoGenerateColumns = false;
            this.dataGridViewLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storidDataGridViewTextBoxColumn,
            this.colLeftSelected});
            this.dataGridViewLeft.DataSource = this.salesBindingSource;
            this.dataGridViewLeft.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLeft.Name = "dataGridViewLeft";
            this.dataGridViewLeft.RowTemplate.Height = 21;
            this.dataGridViewLeft.Size = new System.Drawing.Size(311, 411);
            this.dataGridViewLeft.TabIndex = 1;
            // 
            // btm_Right
            // 
            this.btm_Right.Location = new System.Drawing.Point(373, 199);
            this.btm_Right.Name = "btm_Right";
            this.btm_Right.Size = new System.Drawing.Size(41, 23);
            this.btm_Right.TabIndex = 2;
            this.btm_Right.Text = ">>";
            this.btm_Right.UseVisualStyleBackColor = true;
            this.btm_Right.Click += new System.EventHandler(this.btm_Right_Click);
            // 
            // dataGridViewRight
            // 
            this.dataGridViewRight.AllowUserToAddRows = false;
            this.dataGridViewRight.AllowUserToDeleteRows = false;
            this.dataGridViewRight.AutoGenerateColumns = false;
            this.dataGridViewRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRightSelected,
            this.storidDataGridViewTextBoxColumn1,
            this.ordnumDataGridViewTextBoxColumn,
            this.orddateDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.paytermsDataGridViewTextBoxColumn,
            this.titleidDataGridViewTextBoxColumn});
            this.dataGridViewRight.DataSource = this.salesBindingSource1;
            this.dataGridViewRight.Location = new System.Drawing.Point(420, 12);
            this.dataGridViewRight.Name = "dataGridViewRight";
            this.dataGridViewRight.RowTemplate.Height = 21;
            this.dataGridViewRight.Size = new System.Drawing.Size(311, 411);
            this.dataGridViewRight.TabIndex = 3;
            // 
            // kagayaDataSet
            // 
            this.kagayaDataSet.DataSetName = "kagayaDataSet";
            this.kagayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kagayaDataSetBindingSource
            // 
            this.kagayaDataSetBindingSource.DataSource = this.kagayaDataSet;
            this.kagayaDataSetBindingSource.Position = 0;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.kagayaDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // storidDataGridViewTextBoxColumn
            // 
            this.storidDataGridViewTextBoxColumn.DataPropertyName = "stor_id";
            this.storidDataGridViewTextBoxColumn.HeaderText = "stor_id";
            this.storidDataGridViewTextBoxColumn.Name = "storidDataGridViewTextBoxColumn";
            // 
            // colLeftSelected
            // 
            this.colLeftSelected.HeaderText = "Selected";
            this.colLeftSelected.Name = "colLeftSelected";
            this.colLeftSelected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLeftSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colRightSelected
            // 
            this.colRightSelected.HeaderText = "Selected";
            this.colRightSelected.Name = "colRightSelected";
            this.colRightSelected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRightSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "sales";
            this.salesBindingSource1.DataSource = this.kagayaDataSet;
            // 
            // storidDataGridViewTextBoxColumn1
            // 
            this.storidDataGridViewTextBoxColumn1.DataPropertyName = "stor_id";
            this.storidDataGridViewTextBoxColumn1.HeaderText = "stor_id";
            this.storidDataGridViewTextBoxColumn1.Name = "storidDataGridViewTextBoxColumn1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 435);
            this.Controls.Add(this.dataGridViewRight);
            this.Controls.Add(this.btm_Right);
            this.Controls.Add(this.dataGridViewLeft);
            this.Controls.Add(this.btmLeft);
            this.Name = "Form1";
            this.Text = "Selected_Row_From_DataGrid_another_DGV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kagayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kagayaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmLeft;
        private System.Windows.Forms.DataGridView dataGridViewLeft;
        private System.Windows.Forms.Button btm_Right;
        private System.Windows.Forms.DataGridView dataGridViewRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kagayaDataSetBindingSource;
        private kagayaDataSet kagayaDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private kagayaDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn storidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colLeftSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRightSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn storidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paytermsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesBindingSource1;
    }
}

