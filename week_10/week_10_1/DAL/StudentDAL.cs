using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentDAL : DatabaseConnection
    {
        public List<Student> GetAllStudents()
        {

            List<Student> students = new List<Student>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM STUDENT";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string studentId = reader.GetString(0);
                string studentName = reader.GetString(1);
                string classId = reader.GetString(2);
                students.Add(new Student(studentId, studentName, classId));
            }
            reader.Close();
            CloseConnection();
            return students;
        }
    }
}
