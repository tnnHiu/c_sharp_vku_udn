using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_5
{
    internal abstract class People
    {
        public People()
        {
            Id = 1;
            Name = "Nguyen Van Nam";
        }
        public People(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
