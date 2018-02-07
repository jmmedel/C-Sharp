using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_080_WebBrowser_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser2.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser3.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser4.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser5.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser6.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser7.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser8.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser9.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser10.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser11.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser12.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");

            webBrowser13.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser14.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
            webBrowser15.Navigate("https://www.youtube.com/watch?v=sTiA4Xk6Tzs&list=PLaJv8CC2dxuSZ6bgcZS-IqnZTJGKKmz3w");
           



        }

        private void button1_Click(object sender, EventArgs e)
        {   
            webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            webBrowser2.Refresh();
            webBrowser3.Refresh();
            webBrowser4.Refresh();
            webBrowser5.Refresh();
            webBrowser6.Refresh();
            webBrowser7.Refresh();
            webBrowser8.Refresh();
            webBrowser9.Refresh();
            webBrowser10.Refresh();

            webBrowser11.Refresh();
            webBrowser12.Refresh();
            webBrowser13.Refresh();
            webBrowser14.Refresh();
            webBrowser15.Refresh();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
