using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string ClassId { get; set; }

        public Student(string studentId, string name, string classId)
        {

            StudentId = studentId;
            Name = name;
            ClassId = classId;
        }

    }
}
