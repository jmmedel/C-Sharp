﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace T_000_67_Arraylist
{
    /*
     C# - ArrayList Class
     It represents an ordered collection of an object that can be indexed individually. It is basically an alternative to an array. However, unlike array you can add and remove items from a list at a specified position using an index and the array resizes itself automatically. It also allows dynamic memory allocation, adding, searching and sorting items in the list.

Methods and Properties of ArrayList Class
The following table lists some of the commonly used properties of the ArrayList class −

Sr.No.	Property & Description
1	
Capacity

Gets or sets the number of elements that the ArrayList can contain.

2	
Count

Gets the number of elements actually contained in the ArrayList.

3	
IsFixedSize

Gets a value indicating whether the ArrayList has a fixed size.

4	
IsReadOnly

Gets a value indicating whether the ArrayList is read-only.

5	
Item

Gets or sets the element at the specified index.

The following table lists some of the commonly used methods of the ArrayList class −

Sr.No.	Method & Description
1	
public virtual int Add(object value);

Adds an object to the end of the ArrayList.

2	
public virtual void AddRange(ICollection c);

Adds the elements of an ICollection to the end of the ArrayList.

3	
public virtual void Clear();

Removes all elements from the ArrayList.

4	
public virtual bool Contains(object item);

Determines whether an element is in the ArrayList.

5	
public virtual ArrayList GetRange(int index, int count);

Returns an ArrayList which represents a subset of the elements in the source ArrayList.

6	
public virtual int IndexOf(object);

Returns the zero-based index of the first occurrence of a value in the ArrayList or in a portion of it.

7	
public virtual void Insert(int index, object value);

Inserts an element into the ArrayList at the specified index.

8	
public virtual void InsertRange(int index, ICollection c);

Inserts the elements of a collection into the ArrayList at the specified index.

9	
public virtual void Remove(object obj);

Removes the first occurrence of a specific object from the ArrayList.

10	
public virtual void RemoveAt(int index);

Removes the element at the specified index of the ArrayList.

11	
public virtual void RemoveRange(int index, int count);

Removes a range of elements from the ArrayList.

12	
public virtual void Reverse();

Reverses the order of the elements in the ArrayList.

13	
public virtual void SetRange(int index, ICollection c);

Copies the elements of a collection over a range of elements in the ArrayList.

14	
public virtual void Sort();

Sorts the elements in the ArrayList.

15	
public virtual void TrimToSize();

Sets the capacity to the actual number of elements in the ArrayList.
    */

    namespace CollectionApplication
    {
        class Program
        {
            static void Main(string[] args)
            {
                ArrayList al = new ArrayList();

                Console.WriteLine("Adding some numbers:");
                al.Add(45);
                al.Add(78);
                al.Add(33);
                al.Add(56);
                al.Add(12);
                al.Add(23);
                al.Add(9);

                Console.WriteLine("Capacity: {0} ", al.Capacity);
                Console.WriteLine("Count: {0}", al.Count);

                Console.Write("Content: ");
                foreach (int i in al)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                Console.Write("Sorted Content: ");
                al.Sort();
                foreach (int i in al)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }

}
