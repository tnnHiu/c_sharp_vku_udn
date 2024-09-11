using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_6
{
    internal class LabStaff : Employee
    {
        public double Salary { get; set; }

        public LabStaff() : base()
        {
            Salary = 0;
        }
        public LabStaff(string name, int birthYear, string degree, double salary) : base(name, birthYear, degree)
        {
            Salary = salary;
        }

        public override double CalculateSalary()
        {
            return Salary;
        }
        public override void InputInformation()
        {
            base.InputInformation();
            Console.Write("Nhap luong trong thang: ");
            Salary = double.Parse(Console.ReadLine()!);
        }
        public override void OutputInformation()
        {
            base.OutputInformation();
            Console.WriteLine($"Luong: {Salary}");
        }
    }
}
