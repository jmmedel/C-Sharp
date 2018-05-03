using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_27_Passing_Arrays_As_Function_Arguments
{
    /*
     C# - Passing Arrays as Function Arguments

    */
    class Program
    {   
       
        static void Main(string[] args)
        {
            MyArray app = new MyArray();

            /* an int array with 5 elements */
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;

            /* pass pointer to the array as an argument */
            avg = app.getAverage(balance, balance.Length);

            /* output the returned value */
            Console.WriteLine("Average value is: {0} ", avg);
            Console.ReadLine();
        }
    }

    class MyArray
    {
        public double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;

        }
    }
    /*
     * When the above code is compiled and executed, it produces the following result −

Average value is: 214.4
     */
}
