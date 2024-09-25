using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Exercise_1
{
    internal class Collection_2
    {
        static void Main(string[] args)
        {
            SortedSet<int> mySet = new SortedSet<int>() { 8, 7, 9, 1, 3 };
            mySet.Add(5);
            mySet.Add(4);
            mySet.Add(6);
            mySet.Add(2);
            Console.WriteLine("Element of mySet:\n");
            foreach(var val in mySet)
            {
                Console.Write($"{val, 3}");
            }
        }
    }
}
