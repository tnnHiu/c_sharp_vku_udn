using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_2.Exercise_2
{
    class Person
    {
        private int age;
        private string? name;

        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name!; } set { name = value; } }

        public void DisplayPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine()!;
            Console.Write("Enter age: ");
            Age = int.Parse(Console.ReadLine()!);
        }

        public Person() { }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"Person: name = {Name}, age = {Age}";
        }
    }
}
