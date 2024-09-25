using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Exercise_2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Student()
        {
            Id = 0;
            Name = "";
            Age = 0;
        }
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }

    }
    internal class Program_3
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
                {
                    new Student(1, "Hieu", 21),
                    new Student(2, "Trung", 21),
                    new Student(2, "Van", 21),
                    new Student(2, "Tuan", 21),
                    new Student(2, "Toan", 21),
                    new Student(2, "Trinh", 19),
                    new Student(2, "Phong", 19),
                };
            Console.WriteLine("List of student: ");
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
            students.Sort((st1, st2) => st1.Name.CompareTo(st2.Name));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("List of student after sort by name: ");
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}

