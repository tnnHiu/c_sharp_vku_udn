using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.Exercise_2
{
    //public delegate void SuKienNhapSo(int x);

    class DuLieuNhap : EventArgs
    {
        public int Data { get; set; }
        public DuLieuNhap(int x) { Data = x; }
    }

    // publisher
    class UserInput
    {
        public event EventHandler? SKNhapSo;


        public void Input()
        {
            do
            {
                Console.Write("Nhap vao so nguyen: ");
                string s = Console.ReadLine()!;
                int i = Int32.Parse(s);
                // phat di su kien
                SKNhapSo?.Invoke(this, new DuLieuNhap(i));
            }
            while (true);
        }
    }

    // delegate void Kieu(object? sender, EventArgs args)

    // Subscriber
    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.SKNhapSo += Can;
        }
        public void Can(object? sender, EventArgs e)
        {
            DuLieuNhap duLieuNhap = (DuLieuNhap)e;
            int i = duLieuNhap.Data;
            Console.WriteLine($"Can bac 2 cua {i}: {Math.Sqrt(i)}");
        }
    }

    class TinhBinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.SKNhapSo += BinhPhuong;

        }
        public void BinhPhuong(object? sender, EventArgs e)
        {
            DuLieuNhap duLieuNhap = (DuLieuNhap)e;
            int i = duLieuNhap.Data;
            Console.WriteLine($"Binh phuong cua {i}: {i * i}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CancelKeyPress += (sender, e) =>
            {
                Console.WriteLine();
                Console.WriteLine("Thoat ung dung");
            };


            // publisher
            UserInput userInput = new UserInput();

            userInput.SKNhapSo += (sender, e) =>
            {
                DuLieuNhap duLieuNhap = (DuLieuNhap)e;
                Console.WriteLine($"Ban vua nhap so {duLieuNhap.Data}");
            };


            // subcriber
            TinhCan tinhCan = new TinhCan();
            tinhCan.Sub(userInput);

            // subcriber 2 
            TinhBinhPhuong tinhBinhPhuong = new TinhBinhPhuong();
            tinhBinhPhuong.Sub(userInput);

            userInput.Input();
        }
    }
}
