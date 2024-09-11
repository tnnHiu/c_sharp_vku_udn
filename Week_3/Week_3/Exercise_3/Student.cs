using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_3
{
    internal class Student
    {
        private int sID;
        private string tenSV;
        private string khoa;
        private float diemTB;

        //Constructor mac dinh
        public Student()
        {
            sID = 1;
            tenSV = "Nguyen Van Nam";
            khoa = "CNTT";
            diemTB = 7;
        }

        //Constructor sao chep
        public Student(Student stu)
        {
            sID = stu.sID;
            tenSV = stu.tenSV;
            khoa = stu.khoa;
            diemTB = stu.diemTB;
        }

        public Student(int id, string ten, string kh, float dtb)
        {
            sID = id;
            tenSV = ten;
            khoa = kh;
            diemTB = dtb;
        }

        public int StudentID { get { return sID; } set { sID = value; } }
        public string Name { get { return tenSV; } set { tenSV = value; } }
        public string Faculty { get { return khoa; } set { khoa = value; } }
        public float Mark { get { return diemTB; } set { diemTB = value; } }


        public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.sID);
            Console.WriteLine("Ten SV:{0}", this.tenSV);
            Console.WriteLine("Khoa:{0}", this.khoa);
            Console.WriteLine("Diem TB:{0}", this.diemTB);
        }
    }
}
