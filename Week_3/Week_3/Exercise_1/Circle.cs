using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_1
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(int x, int y, double radius) : base(x, y)
        {
            this.radius = radius;
        }


        public override void Show()
        {
            Console.WriteLine("Circle: ");
            Console.WriteLine($"Center point: {x}, {y}");
            Console.WriteLine($"Radius: {radius}");
        }
        public override string ToString()
        {
            return $"Circle: Center=({x}, {y}), Radius={radius}";
        }
    }
}
