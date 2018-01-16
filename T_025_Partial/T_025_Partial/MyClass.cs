using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_025_Partial
{ // combine  two class with the same filename
    partial class MyClass
    {
        public string Name = "Kagaya";
        public  int Age = 24;
        // partial methods
        partial void Message(string msg);

    }

    
}
