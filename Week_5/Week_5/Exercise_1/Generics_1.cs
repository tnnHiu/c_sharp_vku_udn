using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Exercise_1
{

    public class MyClass<T>
    {
        private T? data;
        public T? Value { get => data; set => data = value; }

        public override string ToString()
        {
            return $"Value: {data}";
        }
    }
    internal class Generics_1
    {
        static void Main(string[] args)
        {
    
            MyClass<string> name = new MyClass<string>() { Value = "Jack" };
            Console.WriteLine(name.ToString());
 
            MyClass<float> version = new MyClass<float>() { Value = 5.5f };
            Console.WriteLine(version.ToString());
        
            dynamic obj = new { Id = 1, Name = "David" };
            MyClass<dynamic> myClass = new MyClass<dynamic>() { Value = obj };
            Console.WriteLine(myClass.ToString());
        }
    }
}
