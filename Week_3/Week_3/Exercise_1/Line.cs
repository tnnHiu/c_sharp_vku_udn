using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_1
{
    internal class Line : Shape
    {
        private int x2;
        private int y2;


        public Line(int x1, int y1, int x2, int y2) : base(x1, x2)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Show()
        {
            Console.WriteLine("Line: ");
            Console.WriteLine($"x1 = {x}");
            Console.WriteLine($"y1 = {y}");
            Console.WriteLine($"x2 = {x2}");
            Console.WriteLine($"y2 = {y2}");
        }
        public override string ToString()
        {
            return $"Line: ({x}, {y}), ({x2}, {y2})";
        }
    }
}
