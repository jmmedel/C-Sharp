using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_34_Constructors
{   /*
    C# Constructors
A class constructor is a special member function of a class that is executed whenever we create new objects of that class.

A constructor has exactly the same name as that of class and it does not have any return type. Following example explains the concept of constructor −

     */
    class Line
    {
        private double length;   // Length of a line

        public Line()
        {
            Console.WriteLine("Object is being created");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Line line = new Line();

            // set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
            Lines lines = new Lines();

            // set line length
            lines.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
            Console.ReadKey();
        }
    }

    /*
     When the above code is compiled and executed, it produces the following result −

Object is being created
Length of line : 6
A default constructor does not have any parameter but if you need, a constructor can 
have parameters. Such constructors are called parameterized constructors. This technique 
helps you to assign initial value to an object at the time of its creation as shown in the following example −

     */


    /*
     C# Destructors
A destructor is a special member function of a class that is executed whenever an object of its class goes out of scope. A destructor has exactly the same name as that of the class with a prefixed tilde (~) and it can neither return a value nor can it take any parameters.

Destructor can be very useful for releasing memory resources before exiting the program. Destructors cannot be inherited or overloaded.

Following example explains the concept of destructor −
     */

    class Lines
    {
        private double length;// Length of a line
        public Lines()// constructor
        {
            Console.WriteLine("Object is being created");
        }
        ~Lines() //destructor
        {
            Console.WriteLine("Object is being deleted");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }

}
