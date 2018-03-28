using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Bridge
 Definition
Decouple an abstraction from its implementation so that the two can vary independently.

Frequency of use:Medium
Participants

    The classes and objects participating in this pattern are:

Abstraction   (BusinessObject)
defines the abstraction's interface.
maintains a reference to an object of type Implementor.
RefinedAbstraction   (CustomersBusinessObject)
extends the interface defined by Abstraction.
Implementor   (DataObject)
defines the interface for implementation classes. This interface doesn't have to correspond exactly to Abstraction's interface; in fact the two interfaces can be quite different. Typically the Implementation interface provides only primitive operations, and Abstraction defines higher-level operations based on these primitives.
ConcreteImplementor   (CustomersDataObject)
implements the Implementor interface and defines its concrete implementation.

 */
namespace Design_Pattern_007_Bridge_Structural_Code
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
