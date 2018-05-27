using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace T_017_Access_Modifiers_Static
{
    class MyClass
    {   // Access Modifiers public you can access it anyware
        // private only in the class
        // default is private 
        public string Names { get; set; }
        public MyClass(string name)
        {
            Names = name;
        }
        // static method helper class you dont need to make instaces of a class 


        public static void ShowMessage (string message)
        {
            MessageBox.Show(message);
        }
          


    }
}
