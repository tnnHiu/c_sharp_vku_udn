using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_2
{
    internal class Cat : Animal
    {
        public Cat() : base("Mammal") { }

        public override string Sound()
        {
            return "Mew Mew";
        }
        public override string Information()
        {
            return base.Information();
        }

        public void Climb(string obj)
        {
            Console.WriteLine($"Climbing {obj}");
        }
    }
}
