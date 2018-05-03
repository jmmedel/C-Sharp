using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_45_Namespaces
{   /*
    C# - Namespaces
    A namespace is designed for providing a way to keep one set of names separate from another. The class names declared in one namespace does not conflict with the same class names declared in another.

Defining a Namespace
A namespace definition begins with the keyword namespace followed by the namespace name as follows −

namespace namespace_name {
   // code declarations
}
To call the namespace-enabled version of either function or variable, prepend the namespace name as follows −

namespace_name.item_name;
     
     */

    namespace first_space
    {
        class namespace_cl
        {
            public void func()
            {
                Console.WriteLine("Inside first_space");
            }
        }
    }
    namespace second_space
    {
        class namespace_cl
        {
            public void func()
            {
                Console.WriteLine("Inside second_space");
            }
        }
    }
    class TestClass
    {
        static void Main(string[] args)
        {
            first_space.namespace_cl fc = new first_space.namespace_cl();
            second_space.namespace_cl sc = new second_space.namespace_cl();
            fc.func();
            sc.func();
            Console.ReadLine();

        }
    }

    /*
     When the above code is compiled and executed, it produces the following result −

Inside first_space
Inside second_space
     */

}
