namespace _022_TCP_IP_Client_And_Server
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btmConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btmSend = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(47, 32);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(127, 19);
            this.txtHost.TabIndex = 3;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(235, 32);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(40, 19);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "8910";
            // 
            // btmConnect
            // 
            this.btmConnect.Location = new System.Drawing.Point(287, 32);
            this.btmConnect.Name = "btmConnect";
            this.btmConnect.Size = new System.Drawing.Size(75, 23);
            this.btmConnect.TabIndex = 6;
            this.btmConnect.Text = "Connect";
            this.btmConnect.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(47, 61);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(277, 132);
            this.txtMessage.TabIndex = 7;
            // 
            // btmSend
            // 
            this.btmSend.Location = new System.Drawing.Point(287, 206);
            this.btmSend.Name = "btmSend";
            this.btmSend.Size = new System.Drawing.Size(75, 23);
            this.btmSend.TabIndex = 8;
            this.btmSend.Text = "Send";
            this.btmSend.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(47, 252);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(277, 113);
            this.txtStatus.TabIndex = 9;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 405);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btmSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btmConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btmConnect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btmSend;
        private System.Windows.Forms.TextBox txtStatus;
    }
}