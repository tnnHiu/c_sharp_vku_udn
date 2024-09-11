using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2.Exercise_3
{
    internal class Program
    {
        static void Input(List<Song> songs)
        {

            Console.Write("Enter number of song: ");
            int numSongs = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < numSongs; i++)
            {
                Console.Write("Enter song: ");
                string[] data = Console.ReadLine()!.Split("_");
                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                songs.Add(song);
            }
        }

        static void Output(List<Song> songs)
        {
            Console.Write("Enter type of list songs: ");
            string? typeList = Console.ReadLine();


            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("1.   Input");
            Console.WriteLine("2.   Output");
            Console.WriteLine("0.   Exit");
            Console.WriteLine("-----------");

        }
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<Song> songs = new List<Song>();
            while (true)
            {
                Menu();
                Console.Write("Enter your choose: ");
                int choose = int.Parse(Console.ReadLine()!);
                switch (choose)
                {
                    case 0:
                        return;
                    case 1:
                        Input(songs);
                        break;
                    case 2:
                        Output(songs);
                        break;
                    default:
                        Console.WriteLine("Plese choose again.");
                        break;
                }
            }
        }
    }
}
