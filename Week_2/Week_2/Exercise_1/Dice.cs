using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2.Exercise_1
{
    class Dice
    {
        private int sides;
        // property
        public int Sides
        {
            get { return sides; }
            set
            {
                if (value < 2)
                {
                    //throw new ArgumentException("Sides > = 2");
                    Console.WriteLine("Sides > = 2");
                }
                else
                {
                    sides = value;
                }
            }
        }
        // method roll dice
        public void Roll()
        {
            Random random = new Random();
            int result = random.Next(1, Sides + 1);
            Console.WriteLine($"Result: {result}");
        }
    }
}
