using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_074_Opening_File_With_Your_App
{
    public partial class Form1 : Form
    {   
        
        public Form1(string path)
        {
            MessageBox.Show(path);
            InitializeComponent();
        }

    }
}
