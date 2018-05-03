using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_Load_User_Control_Dynamically
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_Module1_Click(object sender, EventArgs e)
        {
            if (panel.Controls.Contains(ucModule.Instance))
            {
                panel.Controls.Add(ucModule.Instance);
                ucModule.Instance.Dock = DockStyle.Fill;
                ucModule.Instance.BringToFront();
            }
            else
                ucModule.Instance.BringToFront();
        }

        private void btmModule2_Click(object sender, EventArgs e)
        {
            if (panel.Controls.Contains(ucModule2.Instance))
            {
                panel.Controls.Add(ucModule2.Instance);
                ucModule2.Instance.Dock = DockStyle.Fill;
                ucModule2.Instance.BringToFront();
            }
            else
                ucModule2.Instance.BringToFront();
        }

        private void btmModule3_Click(object sender, EventArgs e)
        {
            if (panel.Controls.Contains(ucModule3.Instance))
            {
                panel.Controls.Add(ucModule3.Instance);
                ucModule3.Instance.Dock = DockStyle.Fill;
                ucModule3.Instance.BringToFront();
            }
            else
                ucModule3.Instance.BringToFront();
        }
    }
}
