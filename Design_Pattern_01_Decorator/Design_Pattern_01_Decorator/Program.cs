using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_01_Decorator
{
    class Program
    {   // show two decorator and the output of various 
        // combinations of the decorators on the basic componet

        class DecoratorPattern
        {
            interface IComponet
            {
                string Operation();
            }
            class Componet : IComponet
            {
                public string Operation()
                {
                    return "I am Walking";
                }
            }

            class DecoratorA : IComponet
            { IComponet componet;
                public DecoratorA(IComponet c)
                {
                    componet = c;
                }
                public string Operation()
                {
                    string s = componet.Operation();
                    s += "and Listening to classic FM";
                    return s;
                }
            }
            class DecoratorB : IComponet
            {
                IComponet componet;
                public string addedState = "Past the coffe Shop";
                public DecoratorB(IComponet c)
                {
                    componet = c;
                }
                public string Operation()
                {
                    string s = componet.Operation();
                    s += "To school";
                    return s;
                }
                public string AddedBehavaior()
                {
                    return "And i Bought Cappucino";
                }
            }

            class Client
            {
                static void Display (string s , IComponet c)
                {
                    Console.WriteLine(s+ c.Operation());

                }
                static void Main()
                {
                    Console.WriteLine("Decorator Pattern");
                    IComponet componet = new Componet();
                    Display("1. Basic Componet :", componet);
                    Display("2. A Decorated : ", new DecoratorA(componet));
                    Display("3. B Decorated : ", new DecoratorB(componet));
                    Display("4. B-A Decorated :", new DecoratorB(new DecoratorA(componet)));
                    // Explicit DecoratorB
                    DecoratorB b = new DecoratorB(new Componet());
                    Display("5. A-B decorated : ", new DecoratorA(b));
                    // invoking its added state and added behavior
                    Console.WriteLine("\t\t\t" + b.addedState + b.AddedBehavaior()) ;
                    Console.Read();

                }
            }
            
        }
    }

    
}
