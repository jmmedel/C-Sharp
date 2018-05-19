namespace Gaddis_05_10_AdditionTutor
{
  partial class frmAdditionTutor
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
      this.lblAddition = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtAnswer = new System.Windows.Forms.TextBox();
      this.btnSubmitAnswer = new System.Windows.Forms.Button();
      this.lblMessage = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblAddition
      // 
      this.lblAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAddition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.lblAddition.Location = new System.Drawing.Point(29, 9);
      this.lblAddition.Name = "lblAddition";
      this.lblAddition.Size = new System.Drawing.Size(177, 60);
      this.lblAddition.TabIndex = 0;
      this.lblAddition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(30, 102);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter Answer";
      // 
      // txtAnswer
      // 
      this.txtAnswer.Location = new System.Drawing.Point(106, 99);
      this.txtAnswer.Name = "txtAnswer";
      this.txtAnswer.Size = new System.Drawing.Size(100, 20);
      this.txtAnswer.TabIndex = 2;
      // 
      // btnSubmitAnswer
      // 
      this.btnSubmitAnswer.Location = new System.Drawing.Point(106, 134);
      this.btnSubmitAnswer.Name = "btnSubmitAnswer";
      this.btnSubmitAnswer.Size = new System.Drawing.Size(100, 23);
      this.btnSubmitAnswer.TabIndex = 3;
      this.btnSubmitAnswer.Text = "Submit Answer";
      this.btnSubmitAnswer.UseVisualStyleBackColor = true;
      this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
      // 
      // lblMessage
      // 
      this.lblMessage.Location = new System.Drawing.Point(12, 173);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new System.Drawing.Size(194, 23);
      this.lblMessage.TabIndex = 4;
      this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // frmAdditionTutor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(227, 204);
      this.Controls.Add(this.lblMessage);
      this.Controls.Add(this.btnSubmitAnswer);
      this.Controls.Add(this.txtAnswer);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblAddition);
      this.Name = "frmAdditionTutor";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Addition Tutor";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblAddition;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtAnswer;
    private System.Windows.Forms.Button btnSubmitAnswer;
    private System.Windows.Forms.Label lblMessage;
  }
}

