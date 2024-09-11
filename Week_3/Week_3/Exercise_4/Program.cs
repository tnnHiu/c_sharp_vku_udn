using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_3.Exercise_4;

namespace Week_3.Exercise_4
{
    internal class Program
    {

        public static Student Nhap1SV(Student student)
        {
            Console.Write("Nhap MaSV: ");
            student.SetStudentID(int.Parse(Console.ReadLine()!));
            Console.Write("Ho ten SV:");
            student.SetName(Console.ReadLine()!);
            Console.Write("Nhap khoa:");
            student.SetFacuty(Console.ReadLine()!);
            Console.Write("Nhap Diem TB:");
            student.SetMark(float.Parse(Console.ReadLine()!));
            return student;
        }
        public static void NhapDS(int n, Student[] DSSV)
        {
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Nhap1SV(DSSV[i]);
            }

        }
        public static void XuatDS(Student[] DSSV)
        {
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student student in DSSV)
            {
                student.Show();
            }
        }

        public static void Main()
        {
            int n;
            Console.WriteLine("Nhap so luong SV: ");
            n = int.Parse(Console.ReadLine()!);
            Student[] DSSV = new Student[n];
            NhapDS(n, DSSV);
            XuatDS(DSSV);
        }

    }
}


