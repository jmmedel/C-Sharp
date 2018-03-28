using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 
     Template Method
     Definition
    Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

    Frequency of use:Medium

    Participants

    The classes and objects participating in this pattern are:

AbstractClass  (DataObject)
defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm
implements a template method defining the skeleton of an algorithm. The template method calls primitive operations as well as operations defined in AbstractClass or those of other objects.
ConcreteClass  (CustomerDataObject)
implements the primitive operations ot carry out subclass-specific steps of the algorithm

    Structural code in C#

This structural code demonstrates the Template method which provides a skeleton calling sequence of methods. One or more steps can be deferred to subclasses which implement these steps without changing the overall calling sequence.

*/

using System;

namespace DoFactory.GangOfFour.Template.Structural
{
    /// <summary>

    /// MainApp startup class for Real-World 

    /// Template Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>

    /// The 'AbstractClass' abstract class

    /// </summary>

    abstract class AbstractClass

    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        // The "Template method"

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }

    /// <summary>

    /// A 'ConcreteClass' class

    /// </summary>

    class ConcreteClassA : AbstractClass

    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        }
    }

    /// <summary>

    /// A 'ConcreteClass' class

    /// </summary>

    class ConcreteClassB : AbstractClass

    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
    }
}



