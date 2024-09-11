using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_3.Exercise_6;

namespace Week_3.Exercise_5
{
    internal class Program
    {
        public static Student Nhap1SV(Student student)
        {
            Console.Write("Nhap MaSV: ");
            student.Id = int.Parse(Console.ReadLine()!);
            Console.Write("Ho ten SV:");
            student.Name = Console.ReadLine()!;
            Console.Write("Nhap khoa:");
            student.Faculty = Console.ReadLine()!;
            Console.Write("Nhap Diem TB:");
            student.Mark = float.Parse(Console.ReadLine()!);
            return student;
        }
        public static void NhapDS(int n, List<Student> students)
        {
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                Nhap1SV(student);
                students.Add(student);
            }

        }
        public static void XuatDS(List<Student> students)
        {
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student student in students)
            {
                student.Show();
            }
        }
        public static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine()!);
            List<Student> students = new ArrayList<Student>();
            NhapDS(n, students);
            XuatDS(students);
        }
    }

    internal class ArrayList<T> : List<T>
    {
        //internal void Add(Scientist scientist)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
