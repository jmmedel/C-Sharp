using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_77_Unsafe_Codes
{   /*C# - Unsafe Codes
    C# allows using pointer variables in a function of 
    code block when it is marked by the unsafe modifier. 
    The unsafe code or the unmanaged code is a code block 
    that uses a pointer variable.
    Pointers
A pointer is a variable whose value is the address of another variable i.e., the direct address of the memory location. similar to any variable or constant, you must declare a pointer before you can use it to store any variable address.

The general form of a pointer declaration is −

type *var-name;
Following are valid pointer declarations −

int    *ip;    /* pointer to an integer 
    double* dp;    /* pointer to a double 
    float* fp;    /* pointer to a float 
    char* ch     /* pointer to a character 
The following example illustrates use of pointers in C#, using the unsafe modifier −
     */
    
        class Program
        {
            static unsafe void Main(string[] args)
            {
                int var = 20;
                int* p = &var;

                Console.WriteLine("Data is: {0} ", var);
                Console.WriteLine("Address is: {0}", (int)p);
                Console.ReadKey();
            }
        }
    
}
