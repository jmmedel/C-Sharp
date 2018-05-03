using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_Multiple_Page_On_The_Form_Using_Panel_Control
{
    public partial class Form1 : Form
    {   //create list panel 
        List<Panel> listpanel = new List<Panel>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void btmPreviews_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listpanel[--index].BringToFront();
        }

        private void btmNext_Click(object sender, EventArgs e)
        {
            if (index < listpanel.Count - 1)
                listpanel[++index].BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        { // addto the list panel
            listpanel.Add(panel1);
            listpanel.Add(panel2);
            listpanel.Add(panel3);
            listpanel[index].BringToFront();
        }
    }
}
