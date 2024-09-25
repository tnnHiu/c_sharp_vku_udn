using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Exercise_1
{
 
    interface IBasic<T> where T : struct
    {
        T Add(T a, T b);
    }

    class MyFirstClass : IBasic<int>
    {

        public int Add(int a, int b) => a + b;

    }
 
    class MySecondClass : IBasic<double>
    {
        public double Add(double a, double b) => a + b;
    }

    internal class Generics_3
    {
       public static void Main(string[] args)
        {
            MyFirstClass myFirstClass = new MyFirstClass();
            dynamic r = myFirstClass.Add(10, 20);
            Console.WriteLine(r);
            MySecondClass mySecondClass = new MySecondClass();
            r = mySecondClass.Add(10.5, 20.5);
            Console.WriteLine(r);
        }
    }
}
