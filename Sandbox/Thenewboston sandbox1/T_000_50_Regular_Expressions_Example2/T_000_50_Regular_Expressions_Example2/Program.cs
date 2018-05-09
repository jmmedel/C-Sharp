using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace T_000_50_Regular_Expressions_Example2
{/*
    Example 2
The following example matches words that start with 'm' and ends with 'e' −
 */

    class Program
    {
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "make maze and manage to measure it";

            Console.WriteLine("Matching words start with 'm' and ends with 'e':");
            showMatch(str, @"\bm\S*e\b");
            Console.ReadKey();
        }
    }
    /*When the above code is compiled and executed, it produces the following result −

Matching words start with 'm' and ends with 'e':
The Expression: \bm\S*e\b
make
maze
manage
measure
     
     */
}
