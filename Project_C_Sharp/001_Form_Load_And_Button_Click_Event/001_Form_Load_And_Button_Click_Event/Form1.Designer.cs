namespace _001_Form_Load_And_Button_Click_Event
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
            this.btmClickMe = new System.Windows.Forms.Button();
            this.lblFormStart = new System.Windows.Forms.Label();
            this.btm_Clear = new System.Windows.Forms.Button();
            this.btm_Exit = new System.Windows.Forms.Button();
            this.lbl_BTM_click = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmClickMe
            // 
            this.btmClickMe.Location = new System.Drawing.Point(52, 159);
            this.btmClickMe.Name = "btmClickMe";
            this.btmClickMe.Size = new System.Drawing.Size(75, 23);
            this.btmClickMe.TabIndex = 0;
            this.btmClickMe.Text = "ClickMe";
            this.btmClickMe.UseVisualStyleBackColor = true;
            this.btmClickMe.Click += new System.EventHandler(this.btmClickMe_Click);
            // 
            // lblFormStart
            // 
            this.lblFormStart.AutoSize = true;
            this.lblFormStart.Location = new System.Drawing.Point(59, 55);
            this.lblFormStart.Name = "lblFormStart";
            this.lblFormStart.Size = new System.Drawing.Size(35, 12);
            this.lblFormStart.TabIndex = 1;
            this.lblFormStart.Text = "label1";
            // 
            // btm_Clear
            // 
            this.btm_Clear.Location = new System.Drawing.Point(158, 159);
            this.btm_Clear.Name = "btm_Clear";
            this.btm_Clear.Size = new System.Drawing.Size(75, 23);
            this.btm_Clear.TabIndex = 2;
            this.btm_Clear.Text = "Clear";
            this.btm_Clear.UseVisualStyleBackColor = true;
            this.btm_Clear.Click += new System.EventHandler(this.btm_Clear_Click);
            // 
            // btm_Exit
            // 
            this.btm_Exit.Location = new System.Drawing.Point(258, 159);
            this.btm_Exit.Name = "btm_Exit";
            this.btm_Exit.Size = new System.Drawing.Size(75, 23);
            this.btm_Exit.TabIndex = 3;
            this.btm_Exit.Text = "Exit";
            this.btm_Exit.UseVisualStyleBackColor = true;
            this.btm_Exit.Click += new System.EventHandler(this.btm_Exit_Click);
            // 
            // lbl_BTM_click
            // 
            this.lbl_BTM_click.AutoSize = true;
            this.lbl_BTM_click.Location = new System.Drawing.Point(59, 90);
            this.lbl_BTM_click.Name = "lbl_BTM_click";
            this.lbl_BTM_click.Size = new System.Drawing.Size(35, 12);
            this.lbl_BTM_click.TabIndex = 4;
            this.lbl_BTM_click.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 261);
            this.Controls.Add(this.lbl_BTM_click);
            this.Controls.Add(this.btm_Exit);
            this.Controls.Add(this.btm_Clear);
            this.Controls.Add(this.lblFormStart);
            this.Controls.Add(this.btmClickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmClickMe;
        private System.Windows.Forms.Label lblFormStart;
        private System.Windows.Forms.Button btm_Clear;
        private System.Windows.Forms.Button btm_Exit;
        private System.Windows.Forms.Label lbl_BTM_click;
    }
}

