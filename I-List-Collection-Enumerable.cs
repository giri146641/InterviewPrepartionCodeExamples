using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// IList<T> is a genaric interface in the System.Collections.Generic namespace that represent collection of objects 
    /// that can be individually accessed by Index. It inherits from 'ICollection<T>' and 'IEnumerable<T>. It provided
    /// methods and properties for adding, removing and accessing elements in a list-like fashion.
    /// </summary>
    public class I_List_Collection_Enumerable
    {
        public void List() 
        {
            IList<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Dispaly elements using Icollection
            DisplayCollection(list);

            // Dispaly elements using IEnumeration
            DisplayEnumeration(list);
        }

        /// <summary>
        /// ICollection<T> is a genaric interface representing collection of objects 
        /// It defines methods and properties for manipulating and enumerating over the collection.
        /// It inherits from IEnumerable
        /// When you need to modify(Add,Remove) or work with collection in more stractured way, or get the count of elements
        /// </summary>
        public void DisplayCollection(ICollection<int> list)
        {
            Console.WriteLine("Elements in the collection");
            foreach (int item in list) Console.WriteLine(item);
        }

        /// <summary>
        /// IEnumerable<T> is a genaric interface representing enumerable collection of objects 
        /// It provides a way to iterate over the collecting using a foreach loop or LINQ queries
        /// </summary>
        public void DisplayEnumeration(IEnumerable<int> list)
        {
            Console.WriteLine("Elements in the enumeration");
            foreach (int item in list) Console.WriteLine(item);
        }

    }
}
