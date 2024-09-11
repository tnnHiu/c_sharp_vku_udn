using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_1
{
    internal class PolyLine : Shape
    {
        private List<(int, int)> points;


        public PolyLine(List<(int, int)> points) : base(points[0].Item1, points[0].Item2)
        {
            this.points = points;
        }

        public override void Show()
        {
            Console.WriteLine("PolyLine: ");
            foreach (var point in points)
            {
                Console.WriteLine($"({point.Item1}, {point.Item2})");
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            string polyLine = "";
            foreach (var point in points)
            {
                polyLine += $"({point.Item1}.{point.Item2})";
            }
            return polyLine;
        }
    }
}
