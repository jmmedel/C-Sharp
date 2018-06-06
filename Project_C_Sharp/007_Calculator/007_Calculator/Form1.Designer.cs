namespace _007_Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.texResult = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Plumber);
            // 
            // texResult
            // 
            this.texResult.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texResult.Location = new System.Drawing.Point(4, 23);
            this.texResult.Name = "texResult";
            this.texResult.ReadOnly = true;
            this.texResult.Size = new System.Drawing.Size(310, 21);
            this.texResult.TabIndex = 1;
            this.texResult.Text = "0";
            this.texResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Plumber);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Plumber);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Poperator);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(260, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 41);
            this.button5.TabIndex = 6;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(260, 95);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 41);
            this.button6.TabIndex = 11;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(196, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 41);
            this.button7.TabIndex = 10;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Poperator);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(132, 95);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 41);
            this.button8.TabIndex = 9;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Plumber);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(68, 95);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 41);
            this.button9.TabIndex = 8;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Plumber);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(4, 95);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(58, 41);
            this.button10.TabIndex = 7;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Plumber);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(196, 142);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(58, 41);
            this.button12.TabIndex = 15;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Poperator);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(132, 142);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(58, 41);
            this.button13.TabIndex = 14;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Plumber);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(68, 142);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(58, 41);
            this.button14.TabIndex = 13;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Plumber);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(4, 142);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(58, 41);
            this.button15.TabIndex = 12;
            this.button15.Text = "1";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Plumber);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(260, 142);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(58, 88);
            this.button16.TabIndex = 21;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(196, 189);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(58, 41);
            this.button17.TabIndex = 20;
            this.button17.Text = "*";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Poperator);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(132, 189);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(58, 41);
            this.button18.TabIndex = 19;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Plumber);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(4, 189);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(122, 41);
            this.button20.TabIndex = 17;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Plumber);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 261);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.texResult);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox texResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
    }
}

