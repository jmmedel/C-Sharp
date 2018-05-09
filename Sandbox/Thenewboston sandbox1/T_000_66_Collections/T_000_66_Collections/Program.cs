using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_66_Collections
{   /*
    C# - Collections
    Collection classes are specialized classes for data storage and retrieval. These classes provide support for stacks, queues, lists, and hash tables. Most collection classes implement the same interfaces.

Collection classes serve various purposes, such as allocating memory dynamically to elements and accessing a list of items on the basis of an index etc. These classes create collections of objects of the Object class, which is the base class for all data types in C#.

Various Collection Classes and Their Usage
The following are the various commonly used classes of the System.Collection namespace. Click the following links to check their detail.

Sr.No.	Class & Description and Useage
1	ArrayList
It represents ordered collection of an object that can be indexed individually.

It is basically an alternative to an array. However, unlike array you can add and remove items from a list at a specified position using an index and the array resizes itself automatically. It also allows dynamic memory allocation, adding, searching and sorting items in the list.

2	Hashtable
It uses a key to access the elements in the collection.

A hash table is used when you need to access elements by using key, and you can identify a useful key value. Each item in the hash table has a key/value pair. The key is used to access the items in the collection.

3	SortedList
It uses a key as well as an index to access the items in a list.

A sorted list is a combination of an array and a hash table. It contains a list of items that can be accessed using a key or an index. If you access items using an index, it is an ArrayList, and if you access items using a key , it is a Hashtable. The collection of items is always sorted by the key value.

4	Stack
It represents a last-in, first out collection of object.

It is used when you need a last-in, first-out access of items. When you add an item in the list, it is called pushing the item and when you remove it, it is called popping the item.

5	Queue
It represents a first-in, first out collection of object.

It is used when you need a first-in, first-out access of items. When you add an item in the list, it is called enqueue and when you remove an item, it is called deque.

6	BitArray
It represents an array of the binary representation using the values 1 and 0.

It is used when you need to store the bits but do not know the number of bits in advance. You can access items from the BitArray collection by using an integer index, which starts from zero.
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
