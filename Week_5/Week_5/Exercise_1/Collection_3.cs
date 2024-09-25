using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Exercise_1
{

    internal class Person3
    {
        public int Age { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Person3()
        {

        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
    public class MyCollection<T> : IEnumerable where T : class, new()
    {
        private List<T> myList = new List<T>();
        public void AddItem(params T[] item) => myList.AddRange(item);
        public IEnumerator<T> GetEnumerator() => myList.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    
    internal class Collection_3
    {
        static void Main(string[] args)
        {
            MyCollection<Person3> collection = new MyCollection<Person3>();
            var p1 = new Person3 { FirstName = "David", LastName = "Simpson", Age = 50 };
            var p2 = new Person3 { FirstName = "Marge", LastName = "Simpson", Age = 45 };
            var p3 = new Person3 { FirstName = "Lisa", LastName = "Simpson", Age = 19 };
            var p4 = new Person3 { FirstName = "Jack", LastName = "Simpson", Age = 16 };
            collection.AddItem(p1, p2, p3, p4);
            foreach (var p in collection)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
