using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(0, 0, 1, 2);
            line.Show();

            Circle circle = new Circle(0, 0, 5);
            line.Show();

            Rectangle rectangle = new Rectangle(0, 0, 2, 0, 2, 2, 0, 2);
            rectangle.Show();

            List<(int, int)> points = new List<(int, int)>
            {
                (1,1),
                (2,2),
                (3,3),
                (4,4),
                (5,5),
                (6,6),
            };
            PolyLine polyLine = new PolyLine(points);
            polyLine.Show();

        }
    }
}
