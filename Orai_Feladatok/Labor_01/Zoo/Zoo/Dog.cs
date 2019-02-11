using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Dog : Animal
    {
        public Dog(string name, bool gender, int weight) : base(name, gender, weight, Animal_type.dog)
        {
        }

        // ctrl + . -> Generate Constructor
        public void Bark()
        {
            Console.WriteLine("Friendly woofs!!");
        }
    }
}
