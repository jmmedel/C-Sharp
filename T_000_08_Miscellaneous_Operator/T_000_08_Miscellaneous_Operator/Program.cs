using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_08_Miscellaneous_Operator
{   /*
    C# - Miscellaneous Operators
     There are few other important operators including sizeof and ? : supported by C#.

Operator	Description	Example
sizeof()	Returns the size of a data type.	sizeof(int), returns 4.
typeof()	Returns the type of a class.	typeof(StreamReader);
&	Returns the address of an variable.	&a; returns actual address of the variable.
*	Pointer to a variable.	*a; creates pointer named 'a' to a variable.
? :	Conditional Expression	If Condition is true ? Then value X : Otherwise value Y
is	Determines whether an object is of a certain type.	If( Ford is Car) // checks if Ford is an object of the Car class.
as	Cast without raising an exception if the cast fails.	Object obj = new StringReader("Hello");
StringReader r = obj as StringReader;

     */
    class Program
    {
        static void Main(string[] args)
        {
            /* example of sizeof operator */
            Console.WriteLine("The size of int is {0}", sizeof(int));
            Console.WriteLine("The size of short is {0}", sizeof(short));
            Console.WriteLine("The size of double is {0}", sizeof(double));

            /* example of ternary operator */
            int a, b;
            a = 10;
            b = (a == 1) ? 20 : 30;
            Console.WriteLine("Value of b is {0}", b);

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("Value of b is {0}", b);
            Console.ReadLine();
        }
    }
}


/*
 When the above code is compiled and executed, it produces the following result −

The size of int is 4
The size of short is 2
The size of double is 8
Value of b is 30
Value of b is 20
     
*/
