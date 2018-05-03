namespace Gaddis_03_03_DistanceCalculator
{
  partial class frmDistanceCalculator
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
      this.btnCalculate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtTime = new System.Windows.Forms.TextBox();
      this.txtSpeed = new System.Windows.Forms.TextBox();
      this.txtDistance = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(127, 97);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(87, 39);
      this.btnCalculate.TabIndex = 0;
      this.btnCalculate.Text = "Calculate Distrance";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 65);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(153, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter Time Travelled (in Hours)";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(30, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(144, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Enter Speed (Miles Per Hour)";
      // 
      // txtTime
      // 
      this.txtTime.Location = new System.Drawing.Point(180, 62);
      this.txtTime.Name = "txtTime";
      this.txtTime.Size = new System.Drawing.Size(100, 20);
      this.txtTime.TabIndex = 3;
      // 
      // txtSpeed
      // 
      this.txtSpeed.Location = new System.Drawing.Point(180, 21);
      this.txtSpeed.Name = "txtSpeed";
      this.txtSpeed.Size = new System.Drawing.Size(100, 20);
      this.txtSpeed.TabIndex = 4;
      // 
      // txtDistance
      // 
      this.txtDistance.Enabled = false;
      this.txtDistance.Location = new System.Drawing.Point(180, 162);
      this.txtDistance.Name = "txtDistance";
      this.txtDistance.Size = new System.Drawing.Size(100, 20);
      this.txtDistance.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(78, 165);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(96, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Distance Travelled";
      // 
      // frmDistanceCalculator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(322, 214);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtDistance);
      this.Controls.Add(this.txtSpeed);
      this.Controls.Add(this.txtTime);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCalculate);
      this.Name = "frmDistanceCalculator";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Distance Calculator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTime;
    private System.Windows.Forms.TextBox txtSpeed;
    private System.Windows.Forms.TextBox txtDistance;
    private System.Windows.Forms.Label label3;
  }
}

