using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Cat : Animal
    {
        public Cat(string name, bool gender, int weight) 
            : base(name, gender, weight, Animal_type.cat)
        {
            
        }

        public void Meow()
        {
            // cw
            Console.WriteLine("MEOW?");
        }
    }
}
