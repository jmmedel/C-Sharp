using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_SMS_Message
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmSend_Click(object sender, EventArgs e)
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                try
                {     //http://smsc.vianett.no/v3/send.ashx?src=xxxxx&dst=xxxxx&msg=Hello+world&username=xxxxx&password=xxxxx
                    string url = "http://smsc.vianett.no/v3/send.ashx?" +
                     "src=" + txtPhoneNumber.Text + "&" +
                     "dst=" + txtPhoneNumber.Text + "&" +
                     "msg=" + System.Web.HttpUtility.UrlEncode(txtMessage.Text, System.Text.Encoding.GetEncoding("ISO-8859-1"))+ "&" +
                     "username" + System.Web.HttpUtility.UrlEncode(txtUserName.Text) + "&" +
                     "password=" + System.Web.HttpUtility.UrlEncode(txtPassword.Text);
                    
                    string result = client.DownloadString(url);
                    if (result.Contains("OK"))
                        MessageBox.Show("Your message has benn succesfull sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Meesage send failure", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (System.Net.WebException ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
