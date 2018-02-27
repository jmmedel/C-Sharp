using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_15_Nested_Loops
{   /*
    C# - Nested Loops
    C# allows to use one loop inside another loop. Following section shows few examples to illustrate the concept.

Syntax
The syntax for a nested for loop statement in C# is as follows −

for ( init; condition; increment ) {
   for ( init; condition; increment ) {
      statement(s);
   }
   statement(s);
}
The syntax for a nested while loop statement in C# is as follows −

while(condition) {
   while(condition) {
      statement(s);
   }
   statement(s);
}
The syntax for a nested do...while loop statement in C# is as follows −

do {
   statement(s);
   do {
      statement(s);
   }
   while( condition );
}
while( condition );
A final note on loop nesting is that you can put any type of loop inside of any other type of loop. For example a for loop can be inside a while loop or vice versa.

Example
The following program uses a nested for loop to find the prime numbers from 2 to 100 −
     */
    class Program
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int i, j;

            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break; // if factor found, not prime
                if (j > (i / j)) Console.WriteLine("{0} is prime", i);
            }
            Console.ReadLine();
        }
    }
}
