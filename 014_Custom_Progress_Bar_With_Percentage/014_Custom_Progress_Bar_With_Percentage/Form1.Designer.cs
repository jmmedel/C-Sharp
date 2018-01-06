namespace _014_Custom_Progress_Bar_With_Percentage
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
            this.btmStart = new System.Windows.Forms.Button();
            this.my_ProgressBars1 = new _014_Custom_Progress_Bar_With_Percentage.My_ProgressBars();
            this.SuspendLayout();
            // 
            // btmStart
            // 
            this.btmStart.Location = new System.Drawing.Point(107, 110);
            this.btmStart.Name = "btmStart";
            this.btmStart.Size = new System.Drawing.Size(75, 23);
            this.btmStart.TabIndex = 0;
            this.btmStart.Text = "Start";
            this.btmStart.UseVisualStyleBackColor = true;
            this.btmStart.Click += new System.EventHandler(this.btmStart_Click);
            // 
            // my_ProgressBars1
            // 
            this.my_ProgressBars1.Location = new System.Drawing.Point(28, 63);
            this.my_ProgressBars1.Name = "my_ProgressBars1";
            this.my_ProgressBars1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.my_ProgressBars1.Size = new System.Drawing.Size(244, 23);
            this.my_ProgressBars1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.my_ProgressBars1);
            this.Controls.Add(this.btmStart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Custom ProgressBar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmStart;
        private My_ProgressBars my_ProgressBars1;
    }
}

