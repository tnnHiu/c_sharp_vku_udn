using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Week_2.Exercise_4
{
    internal class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }


        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("Denominator cannot be 0");
            }
            else
            {
                Numerator = numerator;
                Denominator = denominator;

            }
        }
        // Tìm ước chung lớn nhất
        private int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }


        // rút gọn phân số 
        private void Normalize()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        public void InputFraction()
        {
            Console.Write("Enter the Numerator: ");
            Numerator = int.Parse(Console.ReadLine()!);
            Console.Write("Enter the Denominator: ");
            Denominator = int.Parse(Console.ReadLine()!);
            if (Denominator == 0)
            {
                Console.WriteLine("Denominator cannot be 0");
            }
            Normalize();
        }
        //Cộng hai phân số
        public Fraction Add(Fraction other)
        {
            int numerator = Numerator * other.Denominator + other.Numerator * Denominator;
            int denominator = Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }
        //Trừ hai phân số
        public Fraction Subtract(Fraction other)
        {
            int numerator = Numerator * other.Denominator - other.Numerator * Denominator;
            int denominator = Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }
        // Nhân hai phân số 
        public Fraction Multiply(Fraction other)
        {
            int numerator = Numerator * other.Numerator;
            int denominator = Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }
        // Chia hai phân số
        public Fraction Divide(Fraction other)
        {
            int numerator = Numerator * other.Denominator;
            int denominator = Denominator * other.Numerator;
            return new Fraction(numerator, denominator);
        }
        public void DisplayFraction()
        {
            Normalize();
            Console.WriteLine($"{Numerator} / {Denominator}");
        }
        public void DisplayAsDecimal()
        {
            Console.WriteLine((double)Numerator / Denominator);
        }
    }

}

