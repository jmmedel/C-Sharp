using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace T_089_TrippleDES_Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] encryted;
        private void button1_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();
            TDES.Key = md5.ComputeHash(utf8.GetBytes(textBox1.Text));
            TDES.Mode = CipherMode.ECB;
            TDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = TDES.CreateEncryptor();
            encryted = trans.TransformFinalBlock(utf8.GetBytes(textBox2.Text),0,utf8.GetBytes(textBox2.Text).Length);
            textBox3.Text = BitConverter.ToString(encryted);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();
            TDES.Key = md5.ComputeHash(utf8.GetBytes(textBox4.Text));
            TDES.Mode = CipherMode.ECB;
            TDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = TDES.CreateDecryptor();
            try
            {
                textBox5.Text = utf8.GetString(trans.TransformFinalBlock(encryted, 0, encryted.Length));
            }
            catch (Exception)
            {

                MessageBox.Show("Wrong Key");
            }
            

        }
    }
}
