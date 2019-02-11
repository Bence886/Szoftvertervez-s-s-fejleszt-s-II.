using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    enum Animal_type { cat, dog, bear }
    class Animal
    {
        // ctor 
        // ctrl + . -> Generate Constructor
        public Animal(string name, bool gender, int weight, Animal_type type)
        {
            Name = name;
            Gender = gender;
            Weight = weight;
            Type = type;
        }

        // ctrl + r + e
        // ctrl + . -> Encapsulate Field
        // string name;

        // prop
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Weight { get; set; }
        public Animal_type Type { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} Weight: {Weight}, Type: {Type}";
        }

    }
}
