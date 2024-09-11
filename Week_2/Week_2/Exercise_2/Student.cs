using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2.Exercise_2
{
    internal class Student : Person
    {
        private double gpa;

        public double Gpa { get { return gpa; } set { gpa = value; } }
        public void DisplayStudent()
        {
            base.DisplayPerson();
            Console.WriteLine($"GPA: {Gpa}");
        }
        public new void Input()
        {
            base.Input();
            Console.Write("Enter GPA: ");
            Gpa = double.Parse(Console.ReadLine()!);
        }

        public Student() : base()
        {

        }
        public Student(string name, int age, double gpa) : base(name, age)
        {
            this.gpa = gpa;
        }
    }
}
