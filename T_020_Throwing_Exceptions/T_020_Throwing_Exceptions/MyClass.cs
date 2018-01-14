using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_020_Throwing_Exceptions
{
    class MyClass
    {
        // making you own exceptions
        // to use inside static method you need to be static too

         static Exception exception = new Exception("You can set this tring equal to an empty string");
        public static void Checkingstring(string mystring)
        {   // trowing an exceptions
            if (mystring == "") throw exception;

        }
    }
}
