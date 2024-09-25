using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Exercise_1
{
    class Person1
    {
        public int Age { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Person1()
        {

        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
    internal class Collection_1
    {
        static void Main(string[] args)
        {
            List<Person1> people = new List<Person1>()
            {
                 new Person1() { FirstName = "David", LastName = "Simpson", Age = 50 },
                 new Person1() { FirstName = "Marge", LastName = "Simpson", Age = 45 },
                 new Person1() { FirstName = "Lisa", LastName = "Simpson", Age = 19 },
                 new Person1() { FirstName = "Jack", LastName = "Simpson", Age = 16 },
            };
            Console.WriteLine("Item in list: {0}", people.Count);
            foreach (Person1 p in people)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
