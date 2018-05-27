using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_025_Partial
{   // combine  two class with the same filename
    partial class MyClass
    {
        public string HairColor = "Brown";
        public bool Glasses = false;
        // partial 
        partial void Message(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
        }
        public void ShowMsg(string message)
        {
            Message(message);
        }
    }


}
