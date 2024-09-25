using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Exercise_1
{

    public class MyClass
    {

        public void Display<T, U>(T msg, U value)
        {
            Console.WriteLine($"{msg} : {value}");
        }
    }
    internal class Generics_2
    {
        static void Main()
        {

            MyClass obj = new MyClass();

            obj.Display<string, int>("Integer", 2050);
            obj.Display<double, char>(155.9, 'A');
            obj.Display<float, double>(358.9F, 255.67);
        }
    }
}
