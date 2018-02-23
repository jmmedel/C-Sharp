using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
namespace T_110_Hang_Man_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        enum BodyParts
        {
            head,
            left_Eye,
            right_Eye,
            Mount,
            Right_Arm,
            Left_Arm,
            Body,
            Right_Leg,
            Left_Leg

        }
        void DrawHangPost()
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Brown, 10);
            g.DrawLine(p, new Point(130, 218), new Point(130, 5));
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            g.DrawLine(p, new Point(60, 0), new Point(60, 50));
            DrawbodyPart(BodyParts.head);
            DrawbodyPart(BodyParts.left_Eye);
            DrawbodyPart(BodyParts.right_Eye);
            DrawbodyPart(BodyParts.Mount);
            DrawbodyPart(BodyParts.Body);
            DrawbodyPart(BodyParts.Left_Arm);
            DrawbodyPart(BodyParts.Right_Arm);
            DrawbodyPart(BodyParts.Left_Leg);
            DrawbodyPart(BodyParts.Right_Leg);
            MessageBox.Show(getrandomWord());

        }

        void DrawbodyPart(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue);
            if(bp == BodyParts.head)
            {
                g.DrawEllipse(p, 40, 50, 40, 40);
            }
            else if(bp == BodyParts.left_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 50, 60, 5, 5);
            }
            else if(bp == BodyParts.right_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 63, 60, 5, 5);
            }
            else if(bp == BodyParts.Mount)
            {
                g.DrawArc(p, 50, 60, 20, 20, 45, 90);
            }

            else if(bp == BodyParts.Body)
            {
                g.DrawLine(p, new Point(60, 90), new Point(60, 170));
            }
            else if (bp == BodyParts.Left_Arm)
            {
                g.DrawLine(p, new Point(60, 100), new Point(30, 85));
            }
            else if (bp == BodyParts.Right_Arm)
            {
                g.DrawLine(p, new Point(60, 100), new Point(90, 85));
            }
            else if(bp == BodyParts.Left_Leg)
            {
                g.DrawLine(p, new Point(60, 170), new Point(30, 190));
            }
            else if (bp == BodyParts.Right_Leg)
            {
                g.DrawLine(p, new Point(60, 170), new Point(90, 190));
            }
        }
        string getrandomWord()
        {
            string path = "C:\\Users\\kagaya\\Desktop\\Git\\T_110_Hang_Man_Game\\T_110_Hang_Man_Game\\TextFile1.txt";
            var words = File.ReadAllLines(path);
            Random ran = new Random();
            var Randomwords = ran.Next(0, words.Length - 1);
            var line = words[Randomwords].ToString();
            return line;


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawHangPost();
        }
    }
}
