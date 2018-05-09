using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_026_Abstract
{       // abstract class cant create a instance of a class

     abstract class MyClass
     {
        public static string Name = "Kagaya";
        public static int Age = 24;
        public static void Message(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);  

        }
        // methods in abstract class cant have body {}
        // implemented in drive class 
        protected abstract void Showmessage(string msg);

     }
    // end of Myclass class
    class Mysecondclass : MyClass
    {
        protected override void Showmessage(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
        }

    }
}
