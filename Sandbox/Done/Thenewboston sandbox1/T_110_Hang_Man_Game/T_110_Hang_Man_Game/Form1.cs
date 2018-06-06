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
        string words = "";
        List<Label> labels = new List<Label>();
        int amount;
        private void button1_Click(object sender, EventArgs e)
        {
           
               char letter = textBox1.Text.ToLower().ToCharArray()[0];
            
            if(!char.IsLetter(letter))
            {
                MessageBox.Show("you can only submit letter!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
             if(words.Contains(letter))
             {
                char[] letters = words.ToCharArray();
                for(int i = 0; i < letters.Length; i++)
                {
                    if(letters[i] == letter)
                    {
                        labels[i].Text = letter.ToString();
                        return;
                    }

                }
                foreach (Label l in labels)
                    if (l.Text == "_") return;
                MessageBox.Show("You have won!");
            }
             else
             {
                MessageBox.Show("the letter that you gueesed is in the words","Sorry");
                label2.Text += " " + letter.ToString() + ",";
                DrawbodyPart((BodyParts)amount);
                amount++;
                if(amount == 9)
                {
                    MessageBox.Show("Sorry but you lost! the worlds was " + words);
                    ResetGame();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == words)
            {
                MessageBox.Show("you have mon","Congrats");
                ResetGame();
            }
            else
            {
                MessageBox.Show("the word that you geesues is wring","Sorry");
                DrawbodyPart((BodyParts)amount);
                amount++;
                if (amount == 9)
                {
                    MessageBox.Show("Sorry but you lost! the worlds was " + words);
                    ResetGame();
                }
            }
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
           // DrawbodyPart(BodyParts.head);
           // DrawbodyPart(BodyParts.left_Eye);
           // DrawbodyPart(BodyParts.right_Eye);
           // DrawbodyPart(BodyParts.Mount);
           // DrawbodyPart(BodyParts.Body);
           // DrawbodyPart(BodyParts.Left_Arm);
           // DrawbodyPart(BodyParts.Right_Arm);
           // DrawbodyPart(BodyParts.Left_Leg);
           // DrawbodyPart(BodyParts.Right_Leg);
           //print the wrolds here to debug
           //

        }
        #region DrawbodyPart
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
        #endregion
        string getrandomWord()
        {
            string path = "C:\\Users\\kagaya\\Desktop\\Git\\T_110_Hang_Man_Game\\T_110_Hang_Man_Game\\TextFile1.txt";
            var words = File.ReadAllLines(path);
            Random ran = new Random();
            var Randomwords = ran.Next(0, words.Length - 1);
            var line = words[Randomwords].ToString();
            return line;


        }

        void Makelabels()
        {   

           words = getrandomWord();
           char[] chars = words.ToCharArray();
           int between = 330 / chars.Length - 1;
            for(int i= 0; i < chars.Length -1; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * between) + 10, 80);
                labels[i].Text = "_";
                labels[i].Parent = groupBox2;
                labels[i].BringToFront();
                labels[i].CreateControl();
            }
            label1.Text = "Words Length : " + (chars.Length - 1).ToString();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawHangPost();
            Makelabels();
        }

        void ResetGame()
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            getrandomWord();
            Makelabels();
            DrawHangPost();
            label2.Text = "Missed:";
            textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
