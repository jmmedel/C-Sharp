using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace T_065_playing_Sounds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SoundPlayer s = new SoundPlayer(ofd.FileName);
                // play the media
                //s.Play();
                
                s.PlayLooping();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   // the beep sound 
            SystemSounds.Asterisk.Play();
        }
    }
}
