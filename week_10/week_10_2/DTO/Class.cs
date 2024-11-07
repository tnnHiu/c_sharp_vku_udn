using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Class
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public int Year { get; set; }

        public Class(string classID, string className, int year)
        {
            ClassId = classID;
            ClassName = className;
            Year = year;
        }
    }
}
