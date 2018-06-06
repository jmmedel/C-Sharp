using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace T_000_82_Destroying_Threads
{   /*
    Destroying Threads
The Abort() method is used for destroying threads.

The runtime aborts the thread by throwing a ThreadAbortException. This exception cannot be caught, the control is sent to the finally block, if any.

The following program illustrates this −
     */
    namespace MultithreadingApplication
    {
        class ThreadCreationProgram
        {
            public static void CallToChildThread()
            {
                try
                {
                    Console.WriteLine("Child thread starts");

                    // do some work, like counting to 10
                    for (int counter = 0; counter <= 10; counter++)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine(counter);
                    }

                    Console.WriteLine("Child Thread Completed");
                }
                catch (ThreadAbortException e)
                {
                    Console.WriteLine("Thread Abort Exception");
                }
                finally
                {
                    Console.WriteLine("Couldn't catch the Thread Exception");
                }
            }
            static void Main(string[] args)
            {
                ThreadStart childref = new ThreadStart(CallToChildThread);
                Console.WriteLine("In Main: Creating the Child thread");

                Thread childThread = new Thread(childref);
                childThread.Start();

                //stop the main thread for some time
                Thread.Sleep(2000);

                //now abort the child
                Console.WriteLine("In Main: Aborting the Child thread");

                childThread.Abort();
                Console.ReadKey();
            }
        }
    }
    /*
     When the above code is compiled and executed, it produces the following result −

In Main: Creating the Child thread
Child thread starts
0
1
2
In Main: Aborting the Child thread
Thread Abort Exception
Couldn't catch the Thread Exception 

     */
}
