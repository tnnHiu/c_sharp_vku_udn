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
    }
}
