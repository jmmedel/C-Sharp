using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_019_Propeties
{
    class MyClass
    {
        string mystring;
        public MyClass(string name)
        {
            //Name = name;
            mystring = name;
           
        }
        // this is how to make a propeties 
        // private only can change inside the class

        public string Name
        {
            get
            {
                return mystring;
            }
                
            
            set
            {
                if (value == "")
                {
                    System.Windows.Forms.MessageBox.Show("You cant do that.");
                }
            } 
                
        }
        // signed variable on properties only read
        public string  NameReadonly { get { return mystring; } }

    }
}
