using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_16_Break_Statement
{   /*
    C# - Break Statement
    The break statement in C# has following two usage −

When the break statement is encountered inside a loop, the loop is immediately terminated and program control resumes at the next statement following the loop.

It can be used to terminate a case in the switch statement.

If you are using nested loops (i.e., one loop inside another loop), the break statement will stop the execution of the innermost loop and start executing the next line of code after the block.

Syntax
The syntax for a break statement in C# is as follows −

break;
     */
    class Program
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 10;

            /* while loop execution */
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;

                if (a > 15)
                {
                    /* terminate the loop using break statement */
                    break;
                }
            }
            Console.ReadLine();

        }
    }
}
