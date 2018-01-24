using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_046_Generating_Random_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // using random letter
            char[] letter = "QWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray();
            Random r = new Random();
            label1.Text = letter[r.Next(0, 23)].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // using random letter
            char[] letter = "QWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray();
            Random r = new Random();
            string randomstring = "";
            for (int i = 0; i < 10; i++)
            {
                randomstring += letter[r.Next(0, 25)].ToString();
                label1.Text = randomstring;
            }
        }
    }
}
