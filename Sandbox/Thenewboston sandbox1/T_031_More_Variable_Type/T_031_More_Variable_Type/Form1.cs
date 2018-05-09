using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_031_More_Variable_Type
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // u can just search in wiki pedia for more varialbe type 

            byte myByte = 255;
            short myShort = 0;
            Int16 int16 = myShort;
            int myInt = 0;
            Int32 myInt32 = myInt;
            long mylong = 0;
            Int64 myint64 = mylong;

            // how to unsight just puting u
            sbyte myByte3 = -2;
            ushort myShort3 = 0;
            UInt16 int163 = myShort3;
            uint myInt3 = 0;
            UInt32 myInt323 = myInt3;
            ulong mylong3 = 0;
            UInt64 myint643 = mylong3;

            float myFloat = -4635879F;
            double d = 0.52323;
            
            MessageBox.Show(myFloat.ToString());

        }
    }
}
