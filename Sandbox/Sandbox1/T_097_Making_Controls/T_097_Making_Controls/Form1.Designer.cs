namespace T_097_Making_Controls
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
            this.mybutton2 = new T_097_Making_Controls.Mybutton();
            this.SuspendLayout();
            // 
            // mybutton2
            // 
            this.mybutton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mybutton2.ButtonText = "Kagaya";
            this.mybutton2.Location = new System.Drawing.Point(52, 36);
            this.mybutton2.Name = "mybutton2";
            this.mybutton2.Size = new System.Drawing.Size(71, 27);
            this.mybutton2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 130);
            this.Controls.Add(this.mybutton2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private Mybutton mybutton2;
    }
}

