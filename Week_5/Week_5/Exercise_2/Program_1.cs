using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Exercise_2
{
    internal class Program_1
    {
        static void Main(string[] args)
        {
            // Input: 8 2 2 4 8 16 => Output: 16 8 16
            Console.WriteLine("Enter list of number: ");
            List<int> list = Console.ReadLine()!.Split(" ").Select(int.Parse).ToList();

            for (int i = 0; i< list.Count -1; i++)
            {
                if(list[i] == list[i + 1])
                {
                    list[i] += list[i + 1];
                    list.RemoveAt(i+1);
                    i = -1;
                }
            }
            for(int i = 0; i< list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }           
        }
    }
}
