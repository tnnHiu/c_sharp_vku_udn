using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_6
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Degree { get; set; }

        public Employee()
        {
            Name = "No Name";
            BirthYear = 0;
            Degree = "No Degree";
        }

        public Employee(string name, int birthYear, string degree)
        {
            Name = name;
            BirthYear = birthYear;
            Degree = degree;
        }
        public abstract double CalculateSalary();
        public virtual void InputInformation()
        {
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine()!;
            Console.Write("Nhap nam sinh: ");
            BirthYear = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap bang cap: ");
            Degree = Console.ReadLine()!;
        }
        public virtual void OutputInformation()
        {
            Console.WriteLine($"Ten: {Name}");
            Console.WriteLine($"Nam sinh: {BirthYear}");
            Console.WriteLine($"Bang cap: {Degree}");
        }

    }
}
