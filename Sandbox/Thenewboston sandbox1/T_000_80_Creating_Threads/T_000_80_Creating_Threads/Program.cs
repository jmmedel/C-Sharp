using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace T_000_80_Creating_Threads
{   /*
    Creating Threads
Threads are created by extending the Thread class. The extended Thread class then calls the Start() method to begin the child thread execution.

The following program demonstrates the concept −

     */
    namespace MultithreadingApplication
    {
        class ThreadCreationProgram
        {
            public static void CallToChildThread()
            {
                Console.WriteLine("Child thread starts");
            }
            static void Main(string[] args)
            {
                ThreadStart childref = new ThreadStart(CallToChildThread);
                Console.WriteLine("In Main: Creating the Child thread");
                Thread childThread = new Thread(childref);
                childThread.Start();
                Console.ReadKey();
            }
        }
    }
}
