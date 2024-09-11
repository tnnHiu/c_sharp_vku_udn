using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_1
{
    internal class Rectangle : Shape
    {
        private int x2;
        private int y2;
        private int x3;
        private int y3;
        private int x4;
        private int y4;

        public Rectangle(int x, int y, int x2, int y2, int x3, int y3, int x4, int y4) : base(x, y)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }


        public override void Show()
        {
            Console.WriteLine("Rectangle: ");
            Console.WriteLine($"x1 = {x}");
            Console.WriteLine($"y1 = {y}");
            Console.WriteLine($"x2 = {x2}");
            Console.WriteLine($"y2 = {y2}");
            Console.WriteLine($"x3 = {x3}");
            Console.WriteLine($"y3 = {y3}");
            Console.WriteLine($"x4 = {x4}");
            Console.WriteLine($"y4 = {y4}");
        }
        public override string ToString()
        {
            return $"Rectangle: ({x}, {y}), ({x2}, {y2}), ({x3}, {y3}), ({x4}, {y4})";
        }
    }
}
