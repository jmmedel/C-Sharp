namespace _009_Phone_Book
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
            this.btmSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btmcancel = new System.Windows.Forms.Button();
            this.btmEdit = new System.Windows.Forms.Button();
            this.btmNew = new System.Windows.Forms.Button();
            this.appData = new _009_Phone_Book.AppData();
            this.phoneBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btmSave
            // 
            this.btmSave.Location = new System.Drawing.Point(463, 439);
            this.btmSave.Name = "btmSave";
            this.btmSave.Size = new System.Drawing.Size(75, 23);
            this.btmSave.TabIndex = 5;
            this.btmSave.Text = "Save";
            this.btmSave.UseVisualStyleBackColor = true;
            this.btmSave.Click += new System.EventHandler(this.btmSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumberDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phoneBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(526, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtFullName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 164);
            this.panel1.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "PhoneNumber", true));
            this.txtPhoneNumber.Location = new System.Drawing.Point(102, 16);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(138, 19);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // TxtFullName
            // 
            this.TxtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "FullName", true));
            this.TxtFullName.Location = new System.Drawing.Point(102, 40);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(225, 19);
            this.TxtFullName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(102, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(393, 19);
            this.txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(102, 85);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(393, 76);
            this.txtAddress.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(114, 205);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(424, 19);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_Keypress);
            // 
            // btmcancel
            // 
            this.btmcancel.Location = new System.Drawing.Point(382, 439);
            this.btmcancel.Name = "btmcancel";
            this.btmcancel.Size = new System.Drawing.Size(75, 23);
            this.btmcancel.TabIndex = 4;
            this.btmcancel.Text = "Cancel";
            this.btmcancel.UseVisualStyleBackColor = true;
            this.btmcancel.Click += new System.EventHandler(this.btmcancel_Click);
            // 
            // btmEdit
            // 
            this.btmEdit.Location = new System.Drawing.Point(301, 439);
            this.btmEdit.Name = "btmEdit";
            this.btmEdit.Size = new System.Drawing.Size(75, 23);
            this.btmEdit.TabIndex = 3;
            this.btmEdit.Text = "Edit";
            this.btmEdit.UseVisualStyleBackColor = true;
            this.btmEdit.Click += new System.EventHandler(this.btmEdit_Click);
            // 
            // btmNew
            // 
            this.btmNew.Location = new System.Drawing.Point(220, 439);
            this.btmNew.Name = "btmNew";
            this.btmNew.Size = new System.Drawing.Size(75, 23);
            this.btmNew.TabIndex = 2;
            this.btmNew.Text = "New";
            this.btmNew.UseVisualStyleBackColor = true;
            this.btmNew.Click += new System.EventHandler(this.btmNew_Click);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneBookBindingSource
            // 
            this.phoneBookBindingSource.DataMember = "PhoneBook";
            this.phoneBookBindingSource.DataSource = this.appData;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(550, 474);
            this.Controls.Add(this.btmNew);
            this.Controls.Add(this.btmEdit);
            this.Controls.Add(this.btmcancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btmSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btmcancel;
        private System.Windows.Forms.Button btmEdit;
        private System.Windows.Forms.Button btmNew;
        private System.Windows.Forms.BindingSource phoneBookBindingSource;
        private AppData appData;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}

