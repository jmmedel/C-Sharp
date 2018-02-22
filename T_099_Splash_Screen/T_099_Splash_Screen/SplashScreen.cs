using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_099_Splash_Screen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        Timer t;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 2000;
            t.Start();
            t.Tick += new EventHandler(t_ticks);
        }

        private void t_ticks(object sender, EventArgs e)
        {
            t.Stop();
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

    }
}
