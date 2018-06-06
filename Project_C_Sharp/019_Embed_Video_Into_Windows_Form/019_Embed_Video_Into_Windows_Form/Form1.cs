using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_Embed_Video_Into_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string _yurl;
       
        private void btmGo_Click(object sender, EventArgs e)
        {
            _yurl = txtUrl.Text;
            webBrowser.Navigate(_yurl);

        }
    }
}
