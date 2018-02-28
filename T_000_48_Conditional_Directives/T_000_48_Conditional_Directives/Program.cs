#define DEBUG
#define VC_V10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_48_Conditional_Directives
{   /*
    Conditional Directives
You can use the #if directive to create a conditional directive. Conditional directives are useful for testing a symbol or symbols to check if they evaluate to true. If they do evaluate to true, the compiler evaluates all the code between the #if and the next directive.

Syntax for conditional directive is −

#if symbol [operator symbol]...
Where, symbol is the name of the symbol you want to test. You can also use true and false or prepend the symbol with the negation operator.

The operator symbol is the operator used for evaluating the symbol. Operators could be either of the following −

== (equality)
!= (inequality)
&& (and)
|| (or)
You can also group symbols and operators with parentheses. Conditional directives are used for compiling code for a debug build or when compiling for a specific configuration. A conditional directive beginning with a #if directive must explicitly be terminated with a #endif directive.

The following program demonstrates use of conditional directives −
     
     */
    class Program
    {
        static void Main(string[] args)
        {
#if (DEBUG && !VC_V10)
         Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && VC_V10)
         Console.WriteLine("VC_V10 is defined");
#elif (DEBUG && VC_V10)
            Console.WriteLine("DEBUG and VC_V10 are defined");
#else
         Console.WriteLine("DEBUG and VC_V10 are not defined");
#endif
            Console.ReadKey();
        }
    }

    /*
     When the above code is compiled and executed, it produces the following result −

DEBUG and VC_V10 are defined
     */
}
