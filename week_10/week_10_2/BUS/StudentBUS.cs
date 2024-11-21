using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StudentBUS
    {
        StudentDAL studentDAL = new StudentDAL();

        public List<Student> GetAllStudents()
        {
            return studentDAL.GetAllStudents();
        }

        public bool InsertStudent(Student student)
        {
            //Kiểm tra mã sinh viên đã tồn tại chưa?
            if (studentDAL.CheckExitStudent(student.StudentId))
            {
                return false;
            }
            //Kiểm tra mã lớp có tồn tại không?
            if (!studentDAL.CheckExitCLass(student.ClassId))
            {
                return false;
            }


            return studentDAL.InsertStudent(student);
        }
        public bool UpdateStudent(Student student)
        {
            return studentDAL.UpdateStudent(student);
        }
        public bool DeleteStudent(string studentId)
        {
            return studentDAL.DeleteStudent(studentId);
        }

    }
}
