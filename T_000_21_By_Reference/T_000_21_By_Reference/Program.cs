using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_21_By_Reference
{   /*
    C# - Passing Parameters by Reference
    A reference parameter is a reference to a memory location of a variable. When you pass parameters by reference, unlike value parameters, a new storage location is not created for these parameters. The reference parameters represent the same memory location as the actual parameters that are supplied to the method.

You can declare the reference parameters using the ref keyword. The following example demonstrates this −

     */
    class Program
    {
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();

            /* local variable definition */
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            /* calling a function to swap the values */
            n.swap(ref a, ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
        }
    }
    /*
     When the above code is compiled and executed, it produces the following result −

Before swap, value of a : 100
Before swap, value of b : 200
After swap, value of a : 200
After swap, value of b : 100
It shows that the values have changed inside the swap function and this change reflects in the Main function.
    */
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
        }
    }
}
