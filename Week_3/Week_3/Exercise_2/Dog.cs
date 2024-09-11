using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3.Exercise_2
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }



        public Dog(string breed) : base("Mammal")
        {
            Breed = breed;
        }


        public override string Information()
        {
            return base.Information() + $", Breed: {Breed}";
        }

        public override string Sound()
        {
            return "Gau Gau";
        }
    }
}
