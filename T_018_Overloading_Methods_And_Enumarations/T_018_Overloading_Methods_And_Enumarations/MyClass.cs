using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// add the System.Windows.Forms to use the componets
using System.Windows.Forms;


namespace T_018_Overloading_Methods_And_Enumarations
{
    class MyClass
    {   public string Name { get; set; }
         public int x = (int)Days.Sun;

        public MyClass(string name)
        {
            Name = name;
            Getday();
        }

        public static void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }
        public static void ShowMessage(string msg, int age)
        {
            MessageBox.Show($"{msg} {age} years old  " );
           
        }
        
        
        public  void Getday ()
        {
            MessageBox.Show( "Sun = " + x.ToString());
        }
        // enumarations
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    }
}
