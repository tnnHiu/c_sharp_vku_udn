using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_2
{
    internal class Duck: Animal
    {
        public Duck() : base("Bird") { }

        public override string Sound()
        {
            return "Quack Quack";
        }
        public override string Information()
        {
            return base.Information();
        }

        public void Swim(string obj)
        {
            Console.WriteLine($"Swimming {obj}");
        }
    }
}
