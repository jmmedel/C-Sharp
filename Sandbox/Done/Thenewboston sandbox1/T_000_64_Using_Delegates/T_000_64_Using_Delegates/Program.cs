using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace T_000_64_Using_Delegates
{   /*
    Using Delegates
The following example demonstrates the use of delegate. The delegate printString can be used to reference method that takes a string as input and returns nothing.

We use this delegate to call two methods, the first prints the string to the console, and the second one prints it to a file −
     */
    namespace DelegateAppl
    {

        class PrintString
        {
            static FileStream fs;
            static StreamWriter sw;

            // delegate declaration
            public delegate void printString(string s);

            // this method prints to the console
            public static void WriteToScreen(string str)
            {
                Console.WriteLine("The String is: {0}", str);
            }

            //this method prints to a file
            public static void WriteToFile(string s)
            {
                fs = new FileStream("c:\\message.txt",
                FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(s);
                sw.Flush();
                sw.Close();
                fs.Close();
            }

            // this method takes the delegate as parameter and uses it to
            // call the methods as required
            public static void sendString(printString ps)
            {
                ps("Hello World");
            }

            static void Main(string[] args)
            {
                printString ps1 = new printString(WriteToScreen);
                printString ps2 = new printString(WriteToFile);
                sendString(ps1);
                sendString(ps2);
                Console.ReadKey();
            }
        }
    }
}
