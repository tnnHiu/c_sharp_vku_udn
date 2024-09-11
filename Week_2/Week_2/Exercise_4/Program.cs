using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2.Exercise_4
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction();

            Console.WriteLine("Enter first fraction: ");
            fraction1.InputFraction();

            Console.WriteLine("Enter second fraction: ");
            fraction2.InputFraction();

            Console.WriteLine("------------------------------------------------------");
            Console.Write("Faction 1: ");
            fraction1.DisplayFraction();
            Console.Write("Faction 1 (decimal): ");
            fraction1.DisplayAsDecimal();
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("------------------------------------------------------");
            Console.Write("Faction 2: ");
            fraction2.DisplayFraction();
            Console.Write("Faction 2 (decimal): ");
            fraction2.DisplayAsDecimal();
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("------------------------------------------------------");
            Fraction sum = fraction1.Add(fraction2);
            Console.Write("Sum: ");
            sum.DisplayFraction();
            Console.Write("Sum (decimal): ");
            sum.DisplayAsDecimal();
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("------------------------------------------------------");
            Fraction difference = fraction1.Subtract(fraction2);
            Console.Write("Difference: ");
            difference.DisplayFraction();
            Console.Write("Difference (decimal): ");
            difference.DisplayAsDecimal();
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("------------------------------------------------------");
            Fraction product = fraction1.Multiply(fraction2);
            Console.Write("Product: ");
            product.DisplayFraction();
            Console.Write("Product (decimal): ");
            product.DisplayAsDecimal();
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("------------------------------------------------------");
            Fraction quotient = fraction1.Divide(fraction2);
            Console.Write("Quotient: ");
            quotient.DisplayFraction();
            Console.Write("Quotient (decimal): ");
            quotient.DisplayAsDecimal();
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
