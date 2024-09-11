using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2.Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of sides: ");
            int numOfSides = int.Parse(Console.ReadLine()!);
            if (numOfSides < 2)
            {
                Console.WriteLine("Sides > = 2");
                return;
            }
            Dice dice = new Dice();
            dice.Sides = numOfSides;
            dice.Roll();
        }
    }

}
