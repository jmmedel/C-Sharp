namespace _005_Text_To_Speech
{
    partial class MainForm1
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
            this.cbSelectVoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btmSave = new System.Windows.Forms.Button();
            this.btmResume = new System.Windows.Forms.Button();
            this.btmPause = new System.Windows.Forms.Button();
            this.btmSpeak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSelectVoice
            // 
            this.cbSelectVoice.FormattingEnabled = true;
            this.cbSelectVoice.Items.AddRange(new object[] {
            "NotSEt",
            "Male",
            "Female",
            "Other"});
            this.cbSelectVoice.Location = new System.Drawing.Point(141, 38);
            this.cbSelectVoice.Name = "cbSelectVoice";
            this.cbSelectVoice.Size = new System.Drawing.Size(121, 20);
            this.cbSelectVoice.TabIndex = 0;
            this.cbSelectVoice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Voice";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(503, 293);
            this.textBox1.TabIndex = 2;
            // 
            // btmSave
            // 
            this.btmSave.Location = new System.Drawing.Point(414, 412);
            this.btmSave.Name = "btmSave";
            this.btmSave.Size = new System.Drawing.Size(75, 23);
            this.btmSave.TabIndex = 3;
            this.btmSave.Text = "Save";
            this.btmSave.UseVisualStyleBackColor = true;
            this.btmSave.Click += new System.EventHandler(this.btmSave_Click);
            // 
            // btmResume
            // 
            this.btmResume.Location = new System.Drawing.Point(333, 412);
            this.btmResume.Name = "btmResume";
            this.btmResume.Size = new System.Drawing.Size(75, 23);
            this.btmResume.TabIndex = 4;
            this.btmResume.Text = "Resume";
            this.btmResume.UseVisualStyleBackColor = true;
            this.btmResume.Click += new System.EventHandler(this.btmResume_Click);
            // 
            // btmPause
            // 
            this.btmPause.Location = new System.Drawing.Point(252, 412);
            this.btmPause.Name = "btmPause";
            this.btmPause.Size = new System.Drawing.Size(75, 23);
            this.btmPause.TabIndex = 5;
            this.btmPause.Text = "Pause";
            this.btmPause.UseVisualStyleBackColor = true;
            this.btmPause.Click += new System.EventHandler(this.btmPause_Click);
            // 
            // btmSpeak
            // 
            this.btmSpeak.Location = new System.Drawing.Point(171, 412);
            this.btmSpeak.Name = "btmSpeak";
            this.btmSpeak.Size = new System.Drawing.Size(75, 23);
            this.btmSpeak.TabIndex = 6;
            this.btmSpeak.Text = "Speak";
            this.btmSpeak.UseVisualStyleBackColor = true;
            this.btmSpeak.Click += new System.EventHandler(this.btmSpeak_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 447);
            this.Controls.Add(this.btmSpeak);
            this.Controls.Add(this.btmPause);
            this.Controls.Add(this.btmResume);
            this.Controls.Add(this.btmSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectVoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm1";
            this.Text = "Text to speech";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectVoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btmSave;
        private System.Windows.Forms.Button btmResume;
        private System.Windows.Forms.Button btmPause;
        private System.Windows.Forms.Button btmSpeak;
    }
}

