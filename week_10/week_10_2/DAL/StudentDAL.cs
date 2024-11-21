using DTO;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
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
        // get all data from STUDENT
        public List<Student> GetAllStudents()
        {

            List<Student> students = new List<Student>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM STUDENT";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classID = reader.GetString(2);
                students.Add(new Student(studentID, name, classID));
            }
            reader.Close();
            CloseConnection();
            return students;
        }


        // Insert Student
        public bool InsertStudent(Student student)
        {
            try
            {
                OpenConnection();
                string sql = $"INSERT INTO STUDENT VALUES " +
                    $"('{student.StudentId}','{student.Name}','{student.ClassId}')";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }

        // Exit Student
        public bool CheckExitStudent(string studentID)
        {
            OpenConnection();
            string sql = $"SELECT COUNT(*) FROM STUDENT " +
                $"WHERE STUDENTID = '{studentID}'";
            SqlCommand command = new SqlCommand(sql, conn);
            int count = (int)command.ExecuteScalar();
            CloseConnection();
            return count > 0;
        }
        public bool CheckExitCLass(string classId)
        {
            OpenConnection();
            string sql = $"SELECT COUNT(*) FROM CLASS " +
                $"WHERE CLASSID = '{classId}'";
            SqlCommand command = new SqlCommand(sql, conn);
            int count = (int)command.ExecuteScalar();
            CloseConnection();
            return count > 0;
        }

        // Update Student


        public bool UpdateStudent(Student student)
        {
            try
            {
                OpenConnection();
                string sql = $"UPDATE STUDENT " +
                    $"SET NAME = N'{student.Name}', CLASSID = '{student.ClassId}'" +
                    $"WHERE STUDENTID = '{student.StudentId}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;

        }

        // Delete Student

        public bool DeleteStudent(string studentId)
        {

            try
            {
                OpenConnection();
                string sql = $"DELETE FROM STUDENT WHERE STUDENTID = '{studentId}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0) return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
    }
}
