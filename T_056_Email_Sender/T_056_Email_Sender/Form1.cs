using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace T_056_Email_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // im to lazy to change the name of textbox 3 
            // im lazy to change all the textbox name
            try
            {   
                if(!textBox_Email.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("You need to private an email from  @email.com");
                    return;
                }
                button1.Enabled = false;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(Recipints.Text);
                message.Subject = textBox_Subject.Text;
                message.Body = textBox_Body.Text;
                foreach (string s in Recipints.Text.Split(','))
                {
                    message.To.Add(s);
                }
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(textBox_Email.Text, textBox_Password.Text);
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            finally { button1.Enabled = true; }
            

        }
    }
}
