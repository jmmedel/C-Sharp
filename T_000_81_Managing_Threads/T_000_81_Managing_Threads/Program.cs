using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace T_000_81_Managing_Threads
{   /*
    Managing Threads
The Thread class provides various methods for managing threads.

The following example demonstrates the use of the sleep() method for making a thread pause for a specific period of time.

     */
    class Program
    {   
        public static void CalltoChildThread()
        {
            Console.WriteLine("Child threads start");
            // the read is paused for 5000miliseconds
            int sleepfor = 5000;
            Console.WriteLine("The child thread paused for {0} seconds",sleepfor/1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("The child thread resumes");
        }

        static void Main(string[] args)
        {
            ThreadStart childeref = new ThreadStart(CalltoChildThread);
            Console.WriteLine("In Main: Creating the Child Thread");
            Thread childthread = new Thread(childeref);
            childthread.Start();
            Console.ReadLine();

        }
        /*
         When the above code is compiled and executed, it produces the following result −

In Main: Creating the Child thread
Child thread starts
Child Thread Paused for 5 seconds
Child thread resumes
         */
    }
}
