using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_2
{
    internal abstract class Animal
    {
        private string? type;

        public string Type { get; set; }

        public Animal(string type)
        {
            Type = type;
        }

        public abstract string Sound();
        public virtual string Information()
        {
            return $"Type: {Type}";
        }
    }
}
