using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace T_000_Generic_Delegates
{   /*
    Generic Delegates
You can define a generic delegate with type parameters. For example −

delegate T NumberChanger<T>(T n);
The following example shows use of this delegate −
     */
    delegate T NumberChanger<T>(T n);
    namespace GenericDelegateAppl
    {
        class TestDelegate
        {
            static int num = 10;

            public static int AddNum(int p)
            {
                num += p;
                return num;
            }
            public static int MultNum(int q)
            {
                num *= q;
                return num;
            }
            public static int getNum()
            {
                return num;
            }
            static void Main(string[] args)
            {
                //create delegate instances
                NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
                NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

                //calling the methods using the delegate objects
                nc1(25);
                Console.WriteLine("Value of Num: {0}", getNum());

                nc2(5);
                Console.WriteLine("Value of Num: {0}", getNum());
                Console.ReadKey();
            }
        }
    }
    /*
     When the above code is compiled and executed, it produces the following result −

Value of Num: 35
Value of Num: 175
     */
}
