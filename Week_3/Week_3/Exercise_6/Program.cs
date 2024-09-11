using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_3.Exercise_5;

namespace Week_3.Exercise_6
{
    internal class Program
    {

        public static void DisplayMainMenu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Menu");
            Console.WriteLine("1. Them nhan vien");
            Console.WriteLine("2. In ra danh sach nhan vien");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("--------------------------------");
            Console.Write("Nhap lua chon: ");
        }
        public static void DisplayInputMenu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Chon loai nhan vien:");
            Console.WriteLine("1. Nha khoa hoc");
            Console.WriteLine("2. Nha quan ly");
            Console.WriteLine("3. Nhan vien phong thi nghiem");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("--------------------------------");
            Console.Write("Nhap lua chon: ");
        }

        public static void MainProgram(List<Employee> employees)
        {
            while (true)
            {
                DisplayMainMenu();
                int choice = int.Parse(Console.ReadLine()!);
                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        Console.Write("Nhap so luong nhan vien can them: ");
                        int n = int.Parse(Console.ReadLine()!);
                        Input(n, employees);
                        break;
                    case 2:
                        foreach (Employee e in employees)
                        {
                            e.OutputInformation();
                        }
                        break;
                    default:
                        Console.WriteLine("Vui long nhap lai!");
                        break;
                }
            }
        }

        public static void Input(int n, List<Employee> employees)
        {
            for(int i =0; i< n; i++)
            {
                DisplayInputMenu();
                int choice = int.Parse(Console.ReadLine()!);
                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        Scientist scientist = new Scientist();
                        scientist.InputInformation();
                        employees.Add(scientist);
                        break;
                    case 2:
                        Manager manager = new Manager();
                        manager.InputInformation();
                        employees.Add(manager);
                        break;
                    case 3:
                        LabStaff labStaff = new LabStaff();
                        labStaff.InputInformation();
                        employees.Add(labStaff);
                        break;
                    default:
                        Console.WriteLine("Vui long nhap lai!");
                        break;
                }
            }

        }
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            MainProgram(employees);
        }

    }
}
