namespace _004_Load_User_Control_Dynamically
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
            this.btm_Module1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btmModule2 = new System.Windows.Forms.Button();
            this.btmModule3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btm_Module1
            // 
            this.btm_Module1.Location = new System.Drawing.Point(421, 21);
            this.btm_Module1.Name = "btm_Module1";
            this.btm_Module1.Size = new System.Drawing.Size(75, 23);
            this.btm_Module1.TabIndex = 0;
            this.btm_Module1.Text = "Module";
            this.btm_Module1.UseVisualStyleBackColor = true;
            this.btm_Module1.Click += new System.EventHandler(this.btm_Module1_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(374, 273);
            this.panel.TabIndex = 1;
            // 
            // btmModule2
            // 
            this.btmModule2.Location = new System.Drawing.Point(421, 50);
            this.btmModule2.Name = "btmModule2";
            this.btmModule2.Size = new System.Drawing.Size(75, 23);
            this.btmModule2.TabIndex = 2;
            this.btmModule2.Text = "Module 2";
            this.btmModule2.UseVisualStyleBackColor = true;
            this.btmModule2.Click += new System.EventHandler(this.btmModule2_Click);
            // 
            // btmModule3
            // 
            this.btmModule3.Location = new System.Drawing.Point(421, 79);
            this.btmModule3.Name = "btmModule3";
            this.btmModule3.Size = new System.Drawing.Size(75, 23);
            this.btmModule3.TabIndex = 3;
            this.btmModule3.Text = "Module3";
            this.btmModule3.UseVisualStyleBackColor = true;
            this.btmModule3.Click += new System.EventHandler(this.btmModule3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 335);
            this.Controls.Add(this.btmModule3);
            this.Controls.Add(this.btmModule2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btm_Module1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btm_Module1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btmModule2;
        private System.Windows.Forms.Button btmModule3;
    }
}

