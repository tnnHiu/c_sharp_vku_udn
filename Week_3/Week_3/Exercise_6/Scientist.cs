using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_6
{
    internal class Scientist : Employee
    {
        public int NumOfPubArts { get; set; }
        public string Position { get; set; }
        public int NumOfWIM { get; set; }
        public double SalaryLv { get; set; }

        public Scientist() : base()
        {
            Position = "No position";
            NumOfWIM = 0;
            SalaryLv = 0;
            NumOfPubArts = 0;

        }
        public Scientist(string name, int birthYear, string degree, string position, int numOfPubArts, int numOfWIM, double salaryLv)
            : base(name, birthYear, degree)
        {
            Position = position;
            NumOfWIM = numOfWIM;
            NumOfPubArts = numOfPubArts;

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
            Console.Write("Nhap so bai bao da cong bo: ");
            NumOfPubArts = int.Parse(Console.ReadLine()!);
        }
        public override void OutputInformation()
        {
            base.OutputInformation();
            Console.WriteLine($"Chuc vu: {Position}");
            Console.WriteLine($"So bai bao da cong bo: {NumOfPubArts}");
            Console.WriteLine($"Luong: {CalculateSalary()}");

        }
    }
}
