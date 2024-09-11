using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_5
{
    internal class Student : People
    {
        private string khoa;
        private float diemTB;

        //Constructor mac dinh
        public Student() : base()
        {
            khoa = "CNTT";
            diemTB = 7;
        }
        public Student(int id, string ten, string kh, float dtb) : base(id, ten)
        {
            khoa = kh;
            diemTB = dtb;
        }
        public string Faculty { get { return khoa; } set { khoa = value; } }
        public float Mark { get { return diemTB; } set { diemTB = value; } }

        public void Show()
        {
            Console.WriteLine("MSSV:{0}", Id);
            Console.WriteLine("Ten SV:{0}", Name);
            Console.WriteLine("Khoa:{0}", Faculty);
            Console.WriteLine("Diem TB:{0}", Mark);
        }

    }
}
