using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_023_Indexers
{
    class MyClass
    {   // indexers 
        public string this[int index]
        {   
           
            get { return MyArray[index]; }
            set { MyArray[index] = value; }
        }
        string[] MyArray = { "Adam", "Bob", "Joe" };
    }
}
