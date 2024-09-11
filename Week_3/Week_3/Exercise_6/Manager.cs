using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_6
{
    internal class Manager : Employee
    {
        public string Position { get; set; }
        public int NumOfWIM { get; set; }
        public double SalaryLv { get; set; }

        public Manager() : base()
        {
            Position = "No position";
            NumOfWIM = 0;
            SalaryLv = 0;
        }
        public Manager(string name, int birthYear, string degree, string position, int numOfWIM, double salaryLv)
            : base(name, birthYear, degree)
        {
            Position = position;
            NumOfWIM = numOfWIM;
            SalaryLv = salaryLv;
        }

        public override double CalculateSalary()
        {
            return SalaryLv * NumOfWIM;
        }
        public override void InputInformation()
        {
            base.InputInformation();
            Console.Write("Nhap chuc vu: ");
            Position = Console.ReadLine()!;
            Console.Write("Nhap so ngay cong trong thang: ");
            NumOfWIM = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap bac luong: ");
            SalaryLv = double.Parse(Console.ReadLine()!);
        }
        public override void OutputInformation()
        {
            base.OutputInformation();
            Console.WriteLine($"Chuc vu: {Position}");
            Console.WriteLine($"Luong: {CalculateSalary()}");
        }

    }
}
