using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_70_Collections
{   /*
    C# - Stack Class
    It represents a last-in, first out collection of object.	It is used when you need a last-in, first-out access of items. When you add an item in the list, it is called pushing the item and when you remove it, it is called popping the item.

Methods and Properties of the Stack Class
The following table lists some commonly used properties of the Stack class −

Sr.No.	Property & Description
1	
Count

Gets the number of elements contained in the Stack.

The following table lists some of the commonly used methods of the Stack class −

Sr.No.	Method & Description
1	
public virtual void Clear();

Removes all elements from the Stack.

2	
public virtual bool Contains(object obj);

Determines whether an element is in the Stack.

3	
public virtual object Peek();

Returns the object at the top of the Stack without removing it.

4	
public virtual object Pop();

Removes and returns the object at the top of the Stack.

5	
public virtual void Push(object obj);

Inserts an object at the top of the Stack.

6	
public virtual object[] ToArray();

Copies the Stack to a new array.

Example
The following example demonstrates use of Stack −

     */
    using System.Collections;

    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");

            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.ReadLine();
        }
    }

}
