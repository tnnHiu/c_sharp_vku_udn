using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Exercise_2
{
    internal class Program_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter list of number: ");
            List<int> list = Console.ReadLine()!.Split(" ").Select(int.Parse).ToList();
            int n = list.Count;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                int first = list[i];
                int last = list[n - i - 1];
                if (i != n - i - 1)
                {
                    list[i] = first + last;
                    list.RemoveAt(n - i - 1);
                }
                else
                {
                    list[i] = first;
                }
            }
            for (int i = 0; i < list.Count; i++) { 
            Console.Write(list[i]+ " ");
            }
        }
    }
}
