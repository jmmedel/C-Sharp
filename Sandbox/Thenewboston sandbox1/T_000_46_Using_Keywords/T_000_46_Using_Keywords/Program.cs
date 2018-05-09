using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_46_Using_Keywords
{   /*
    The using Keyword
The using keyword states that the program is using the names in the given namespace. For example, we are using the System namespace in our programs. The class Console is defined there. We just write −

Console.WriteLine ("Hello there");
We could have written the fully qualified name as −

System.Console.WriteLine("Hello there");
You can also avoid prepending of namespaces with the using namespace directive. This directive tells the compiler that the subsequent code is making use of names in the specified namespace. The namespace is thus implied for the following code −

Let us rewrite our preceding example, with using directive −
     */

    using first_space;
    using second_space;

    namespace first_space
    {
        class abc
        {
            public void func()
            {
                Console.WriteLine("Inside first_space");
            }
        }
    }
    namespace second_space
    {
        class efg
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
            abc fc = new abc();
            efg sc = new efg();
            fc.func();
            sc.func();
            Console.ReadKey();
        }
    }
    /*
     When the above code is compiled and executed, it produces the following result −

Inside first_space
Inside second_space
     */

}
