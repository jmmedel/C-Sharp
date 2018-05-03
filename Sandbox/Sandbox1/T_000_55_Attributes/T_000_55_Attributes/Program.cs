#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace T_000_55_Attributes
{   /*
    C# - Attributes
    An attribute is a declarative tag that is used to convey information to runtime about the behaviors of various elements like classes, methods, structures, enumerators, assemblies etc. in your program. You can add declarative information to a program by using an attribute. A declarative tag is depicted by square ([ ]) brackets placed above the element it is used for.

Attributes are used for adding metadata, such as compiler instruction and other information such as comments, description, methods and classes to a program. The .Net Framework provides two types of attributes: the pre-defined attributes and custom built attributes.

Specifying an Attribute
Syntax for specifying an attribute is as follows −

[attribute(positional_parameters, name_parameter = value, ...)]
element
Name of the attribute and its values are specified within the square brackets, before the element to which the attribute is applied. Positional parameters specify the essential information and the name parameters specify the optional information.

Predefined Attributes
The .Net Framework provides three pre-defined attributes −

AttributeUsage
Conditional
Obsolete
AttributeUsage
The pre-defined attribute AttributeUsage describes how a custom attribute class can be used. It specifies the types of items to which the attribute can be applied.

Syntax for specifying this attribute is as follows −

[AttributeUsage (
   validon,
   AllowMultiple = allowmultiple,
   Inherited = inherited
)]
Where,

The parameter validon specifies the language elements on which the attribute can be placed. It is a combination of the value of an enumerator AttributeTargets. The default value is AttributeTargets.All.

The parameter allowmultiple (optional) provides value for the AllowMultiple property of this attribute, a Boolean value. If this is true, the attribute is multiuse. The default is false (single-use).

The parameter inherited (optional) provides value for the Inherited property of this attribute, a Boolean value. If it is true, the attribute is inherited by derived classes. The default value is false (not inherited).

For example,
[AttributeUsage(
   AttributeTargets.Class |
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property, 
   AllowMultiple = true)]

    Conditional
This predefined attribute marks a conditional method whose execution depends on a specified preprocessing identifier.

It causes conditional compilation of method calls, depending on the specified value such as Debug or Trace. For example, it displays the values of the variables while debugging a code.

Syntax for specifying this attribute is as follows −

[Conditional(
   conditionalSymbol
)]
For example,

[Conditional("DEBUG")]
The following example demonstrates the attribute −
     */


    public class Myclass
    {
        [Conditional("DEBUG")]

        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Test
    {
        static void function1()
        {
            Myclass.Message("In Function 1.");
            function2();
        }
        static void function2()
        {
            Myclass.Message("In Function 2.");
        }
        public static void Main()
        {
            Myclass.Message("In Main function.");
            function1();
            Console.ReadKey();
        }
    }

    /*When the above code is compiled and executed, it produces the following result −

In Main function
In Function 1
In Function 2
     
     */
}
