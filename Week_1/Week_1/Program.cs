using System.Numerics;
using System.Text;

namespace Week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int preNumber = 7;

            while (preNumber > 0)
            {
                Console.Write("Hãy nhập số bạn dự đoán: ");
                int number = int.Parse(Console.ReadLine());
                if (number < randomNumber)
                {
                    Console.WriteLine("Số bạn dự đoán nhỏ hơn số random");
                   
                    preNumber--;
                }
                else if (number > randomNumber)
                {
                    Console.WriteLine("Số bạn dự đoán lớn hơn số random");
                    preNumber--;
                }
                else
                {
                    Console.WriteLine("Bạn đã đoán đúng!");
                    return;
                }
            }
            Console.WriteLine("Bạn đã thua!");
        }
    }
}
//-------------------------------------------------------------------------------
// Ex 1
//static void Main(string[] args)
//{
//Console.OutputEncoding = Encoding.UTF8;
//Console.WriteLine($"Nhập họ và tên: ");
//string name = Console.ReadLine();
//Console.WriteLine("Nhập điểm thi cuối kỳ: ");
//double score = double.Parse(Console.ReadLine());

//string rank;
//if (score >= 8 && score <= 10)
//{
//    rank = "Gioi";
//}
//else if (score >= 6.5 && score < 8)
//{
//    rank = "Kha";
//}
//else if (score >= 5 && score < 6.5)
//{
//    rank = "Trung bình";
//}
//else if (score >= 0 && score < 5)
//{
//    rank = "Yếu";
//}
//else
//{
//    rank = "Điểm đã nhập không hợp lệ";
//}
//Console.WriteLine($"Họ và tên: {name}");
//Console.WriteLine($"Xếp loại: {rank}");
//}
//-------------------------------------------------------------------------------

// Ex 2
//static void Main(string[] args)
//{
//Console.OutputEncoding = Encoding.UTF8;

//Console.WriteLine("ax^2 + bx + c");
//Console.Write("Nhập a: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Nhập b: ");
//int b = int.Parse(Console.ReadLine());
//Console.Write("Nhập c: ");
//int c = int.Parse(Console.ReadLine());
//double d = (b ^ 2) - (4 * a * c);
//if (d < 0)
//{
//    Console.WriteLine("Phương trình vô nghiệm");
//}
//else if (d == 0)
//{
//    double x = -b / (2 * a);
//    Console.WriteLine($"Phương trình có nghiệm kép: {x}");
//}
//else if (d > 0)
//{
//    double x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
//    double x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
//    Console.WriteLine($"Phương trình 2 có nghiệm: x1 = {x1}, x2 = {x2}");
//}
//}
//-------------------------------------------------------------------------------

//Ex 3
//static void Main(string[] args)
//{
//    Console.OutputEncoding = Encoding.UTF8;
//    while (true)
//    {
//        Console.Write("Nhập số: ");
//        int n = int.Parse(Console.ReadLine());
//        if (n > 0)
//        {
//            Console.WriteLine($"{n} là số nguyên dương!");
//            return;
//        }
//    }
//}
//-------------------------------------------------------------------------------

// Ex 4
//static bool IsPrime(int n)
//{
//    if (n < 2) return false;
//    for (int i = 2; i < Math.Sqrt(n); i++)
//    {
//        if (n % i == 0) return false;
//    }
//    return true;
//}
//static void Main(string[] args)
//{
//    Console.OutputEncoding = Encoding.UTF8;
//    Console.Write("Nhập số: ");
//    int n = int.Parse(Console.ReadLine());
//    if (IsPrime(n))
//    {
//        Console.WriteLine($"{n} là số nguyên tố");
//    }
//    else
//    {
//        Console.WriteLine($"{n} không phải là số nguyên tố");
//    }
//}
//-------------------------------------------------------------------------------

// Ex 5
//static void Main(string[] args)
//{
//    Console.OutputEncoding = Encoding.UTF8;
//    Console.Write("Nhập số năm: ");
//    int year = int.Parse(Console.ReadLine());
//    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
//    {
//        Console.WriteLine($"{year} là năm nhuận");
//        return;
//    }
//    Console.WriteLine($"{year} không là năm nhuận");
//}
//-------------------------------------------------------------------------------

// Ex 6
//static void Main(string[] args)
//{
//    Console.OutputEncoding = Encoding.UTF8;
//    Console.Write("Nhập n: ");
//    int n = int.Parse(Console.ReadLine());
//    double sum = 0;
//    for (int i = 1; i <= n; i++)
//    {

//        sum += (1 / (double)i);
//    }
//    Console.WriteLine($"Kết quả: {sum}");
//}
//-------------------------------------------------------------------------------

// Ex 7
//static void Main(string[] args)
//{
//    Console.OutputEncoding = Encoding.UTF8;
//    Random random = new Random();
//    int randomNumber = random.Next(1, 11);
//    int preNumber = 7;

//    while (preNumber > 0)
//    {
//        Console.Write("Hãy nhập số bạn dự đoán: ");
//        int number = int.Parse(Console.ReadLine());
//        if (number < randomNumber)
//        {
//            Console.WriteLine("Số bạn dự đoán nhỏ hơn số random");
//            preNumber--;
//        }
//        else if (number > randomNumber)
//        {
//            Console.WriteLine("Số bạn dự đoán lớn hơn số random");
//            preNumber--;
//        }
//        else
//        {
//            Console.WriteLine("Bạn đã đoán đúng!");
//            return;
//        }
//    }
//    Console.WriteLine("Bạn đã thua!");
//}
//-------------------------------------------------------------------------------








