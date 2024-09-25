using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Exercise_3
{

    interface IBook1
    {
        // Mô tả indexer chương sách
        string this[int index] { get; set; }
        // Property
        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        string ISBN { get; set; }
        int Year { get; set; }
        void Show();
    }
    class Book1 : IBook1, IComparable<Book1>
    {

        #region Định nghĩa dữ liệu 
        private string? isbn;
        private string? title;
        private string? author;
        private string? publisher;
        private int year;
        private ArrayList chappter = new ArrayList();
        #endregion

        #region Thực thi Interface IBook
        public string this[int index] // chỉ số của chương sách
        {
            get
            {
                if (index >= 0 && index < chappter.Count)
                {
                    return (string)chappter[index]!;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < chappter.Count)
                {
                    chappter[index] = value;  // cập nhật lại chương
                }
                else if (index == chappter.Count)
                {
                    chappter[index] = value;   // thêm chương mới
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public string Title { get { return title!; } set { Title = value; } }
        public string Author { get { return author!; } set { Author = value; } }
        public string Publisher { get { return publisher!; } set { Publisher = value; } }
        public string ISBN { get { return isbn!; } set { ISBN = value; } }
        public int Year { get { return year; } set { Year = value; } }

        public int CompareTo(Book1? other)
        {
            return this.Title.CompareTo(other!.Title);
        }

        public void Show()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chappter.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}: {chappter[i]}");
            }
            Console.WriteLine("-----------------------------");
        }
        #endregion
        public void Input()
        {
            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("Author: ");
            author = Console.ReadLine();
            Console.Write("Publicsher: ");
            publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Input chappter: (finished with empty string)");
            string str;
            do
            {
                str = Console.ReadLine()!;
                if (str.Length > 0)
                {
                    chappter.Add(str);
                }
            } while (str.Length > 0);
        }
    }

    class BookList1
    {
        private List<Book1> list = new List<Book1>();
        public void AddBook()
        {
            Book1 book1 = new Book1();
            book1.Input();
            list.Add(book1);
        }
        public void ShowList()
        {
            foreach (Book1 book1 in list)
            {
                book1.Show();
            }
        }
        public void InputList()
        {
            int n;
            Console.Write("Amount of books: ");
            n = int.Parse(Console.ReadLine()!);
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }
        public void SortByTitle()
        {
            list.Sort();
        }

    }
    internal class Program_2
    {
        static void Main(string[] args)
        {
            BookList1 bookList1 = new BookList1();
            bookList1.InputList();
            bookList1.SortByTitle();
            bookList1.ShowList();
        }
    }
}
