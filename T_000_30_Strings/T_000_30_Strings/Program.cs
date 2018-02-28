using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_30_Strings
{   /*C# - Strings
    In C#, you can use strings as array of characters, However, more common practice is to use the string keyword to declare a string variable. The string keyword is an alias for the System.String class.

Creating a String Object
You can create string object using one of the following methods −

By assigning a string literal to a String variable

By using a String class constructor

By using the string concatenation operator (+)

By retrieving a property or calling a method that returns a string

By calling a formatting method to convert a value or an object to its string representation

The following example demonstrates this −
    
     */
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            StringContainsstring();
            Console.ReadLine();
        }

        public static void  StringContainsstring()
        {
            string str = "This is test";

            if (str.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }
            Console.ReadKey();
        }
    }
}
