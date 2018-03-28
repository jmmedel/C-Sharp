using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Prototype
 Definition
Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.

Frequency of use:Medium
Participants

    The classes and objects participating in this pattern are:

Prototype  (ColorPrototype)
declares an interface for cloning itself
ConcretePrototype  (Color)
implements an operation for cloning itself
Client  (ColorManager)
creates a new object by asking a prototype to clone itself
Structural code in C#

This structural code demonstrates the Prototype pattern in which new objects are created by copying pre-existing objects (prototypes) of the same class.

*/
using System;

namespace DoFactory.GangOfFour.Prototype.Structural
{
    /// <summary>

    /// MainApp startup class for Structural

    /// Prototype Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Create two instances and clone each


            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>

    /// The 'Prototype' abstract class

    /// </summary>

    abstract class Prototype

    {
        private string _id;

        // Constructor

        public Prototype(string id)
        {
            this._id = id;
        }

        // Gets id

        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }

    /// <summary>

    /// A 'ConcretePrototype' class 

    /// </summary>

    class ConcretePrototype1 : Prototype

    {
        // Constructor

        public ConcretePrototype1(string id)
          : base(id)
        {
        }

        // Returns a shallow copy

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    /// <summary>

    /// A 'ConcretePrototype' class 

    /// </summary>

    class ConcretePrototype2 : Prototype

    {
        // Constructor

        public ConcretePrototype2(string id)
          : base(id)
        {
        }

        // Returns a shallow copy

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
