using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "David", "Jane", "Peter", "John", "Mark" };
            var item = from word in names where word.Contains("a") select word;
            foreach (string s in item)
            {
                Console.WriteLine(s);
            }
        }
    }
}

// ------------------------------------------------------ vd1
//public delegate int MyDelegate(int x, int y);
//internal class Program
//{
//    static int Add(int x, int y) => x + y;
//    static int Subtract(int x, int y) => x - y;
//    static void Main(string[] args)
//    {
//        int n1 = 25;
//        int n2 = 15;
//        int result;
//        MyDelegate obj1 = new MyDelegate(Add);
//        result = obj1(n1, n2);
//        Console.WriteLine($"{n1} + {n2} = {result}");

//        MyDelegate obj2 = new MyDelegate(Subtract);
//        result = obj2(n1, n2);
//        Console.WriteLine($"{n1} - {n2} = {result}");
//    }
//}
// ------------------------------------------------------

// ------------------------------------------------------ vd2
//public delegate void MyDelegate(string msg);
//class MyClass
//{
//    public static void Print(string msg) => Console.WriteLine(msg.ToUpper());
//    public static void Show(string msg) => Console.WriteLine(msg.ToLower());
//}
//internal class Program
//{
//    static void InvokeDelagate(MyDelegate dlg, string msg) => dlg(msg);
//    static void Main(string[] args)
//    {
//        string msg = "Passing Delegate As A Parameter";
//        InvokeDelagate(MyClass.Print, msg);
//        InvokeDelagate(MyClass.Show, msg);
//    }
//}
// ------------------------------------------------------

// ------------------------------------------------------vd3
//internal delegate void MyDelegate(string msg);
//class MyClass
//{
//    public static void Print(string message) => Console.WriteLine(message.ToUpper());
//    public static void Show(string message) => Console.WriteLine(message.ToLower());
//    public static void Display(string message) => Console.WriteLine(message);
//}
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string msg = "Multicast Delegate";
//        MyDelegate dele1 = MyClass.Print;
//        MyDelegate dele2 = MyClass.Show;
//        Console.WriteLine("***Combines dele1 + dele2***");
//        MyDelegate? dele = dele1 + dele2;
//        dele(msg);
//        Console.WriteLine("***Combines dele1 + dele2 + dele3");
//        MyDelegate dele3 = MyClass.Display;
//        dele += dele3;
//        dele(msg);
//        Console.WriteLine("***Remove dele2***");
//        dele -= dele2;
//        dele!(msg);
//    }
//}
// ------------------------------------------------------

// ------------------------------------------------------vd4
//internal delegate void MyDelegate(int value);
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        MyDelegate printValue = delegate (int val) {
//            Console.WriteLine($"Inside Anonymous method. Value: {val}");
//        };
//        printValue += delegate
//        {
//            Console.WriteLine("This is Anonymous method.");
//        };
//        printValue(100);
//    }
//}
// ------------------------------------------------------

// ------------------------------------------------------vd5
//class Program
//{
//    static int Sum(int x, int y) => x + y;
//    static void Print(String msg) => Console.WriteLine(msg.ToUpper());
//    static void Main(string[] args)
//    {
//        int a = 15, b = 25, s;
//        string strResult;
//        Func<int, int, int> sumFunc = Sum;
//        s = sumFunc(a, b);
//        strResult = $"{a} + {b} = {s}";
//        Console.WriteLine("***Invoke Print method by Action delegate");
//        Action<string> action = Print;
//        action(strResult);
//    }
//}
// ------------------------------------------------------

// ------------------------------------------------------vd6
//public delegate void PrintDetail(string msg);
//internal class Program
//{
//    event PrintDetail? Print;
//    void Show(string msg) => Console.WriteLine(msg.ToUpper());
//    static void Main(string[] args)
//    {
//        Program p = new Program();
//        p.Print += new PrintDetail(p.Show);
//        p.Print("Hello World");
//    }
//}
// ------------------------------------------------------

// ------------------------------------------------------vd7
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int n1 = 35;
//        int n2 = 45;
//        int result;
//        Func<int, int, int> addNumber = ((a, b) => a + b);
//        result = addNumber(n1, n2);
//        Console.WriteLine($"{n1} + {n2} = {result}");
//    }
//}
// ------------------------------------------------------

// ------------------------------------------------------vd8
//class Program
//{
//    static void Main(string[] args)
//    {
//        string[] names = { "David", "Jane", "Peter", "John", "Mark" };
//        // sap xep theo ten
//        foreach (string item in names.OrderBy(s => s))
//        {
//            Console.WriteLine(item);
//        }
//    }
//}
// ------------------------------------------------------

// ------------------------------------------------------vd9
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string[] names = { "David", "Jane", "Peter", "John", "Mark" };
//        var item = from word in names where word.Contains("a") select word;
//        foreach (string s in item)
//        {
//            Console.WriteLine(s);
//        }
//    }
//}
// ------------------------------------------------------
