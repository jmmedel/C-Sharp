using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// you  need to download Zen.barcode to use this 
namespace _011_Generate_Barcode_And_Qr_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox.Image = barcode.Draw(txtBarcode.Text, 50);
            }
            catch (Exception ex )
            {

                MessageBox.Show("type Barcode code ","Message" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btmQRCode_Click(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pictureBox.Image = qrcode.Draw(txtQRCode.Text, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show("type QRcode ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
