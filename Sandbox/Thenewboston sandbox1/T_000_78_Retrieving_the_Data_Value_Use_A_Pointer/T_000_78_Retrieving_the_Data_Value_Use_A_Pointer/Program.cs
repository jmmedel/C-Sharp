using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_78_Retrieving_the_Data_Value_Use_A_Pointer
{   /*
    Retrieving the Data Value Using a Pointer
You can retrieve the data stored at the located referenced by the pointer variable, using the ToString() method. The following example demonstrates this −
     */
    namespace UnsafeCodeApplication
    {
        class Program
        {
            public static  void Main()
            {
                unsafe
                {
                    int var = 20;
                    int* p = &var;

                    Console.WriteLine("Data is: {0} ", var);
                    Console.WriteLine("Data is: {0} ", p->ToString());
                    Console.WriteLine("Address is: {0} ", (int)p);
                }
                Console.ReadKey();
            }
        }
    }
}
