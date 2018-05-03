using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 001
namespace _001_Form_Load_And_Button_Click_Event
{
    public partial class Form1 : Form
    { // start intialize Componet()
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            lblFormStart.Text = "This text is set on start up";
        }
        //btm handler click
        private void btmClickMe_Click(object sender, EventArgs e)
        {
            lbl_BTM_click.Text = "This is set on click button";
        }
        //clear btm
        private void btm_Clear_Click(object sender, EventArgs e)
        {
            lbl_BTM_click.Text = string.Empty;
        }
        // exit the application
        private void btm_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
