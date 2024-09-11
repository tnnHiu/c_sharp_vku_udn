using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Dog");
            Dog dog = new Dog("Chihuahua");
            Console.WriteLine(dog.Information());
            Console.WriteLine(dog.Sound());



            Console.WriteLine("------------------------------------");
            Console.WriteLine("Cat");
            Cat cat = new Cat();
            Console.WriteLine(cat.Information());
            Console.WriteLine(cat.Sound());
            cat.Climb("tree");

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Duck");
            Duck duck = new Duck();
            Console.WriteLine(duck.Information());
            Console.WriteLine(duck.Sound());
            duck.Swim("pool");          
        }
    }
}
