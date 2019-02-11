
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Cage
    {
        // prop 
        public Animal[] Animals { get; private set; }
        // ctor
        public Cage(int size)
        {
            Animals = new Animal[size];
        }

        public void Add(Animal newAnimal)
        {
            int i = 0;
            while (i < Animals.Length && Animals[i] != null)
            {
                i++;
            }
            if (i < Animals.Length)
            {
                Animals[i] = newAnimal;
            }
        }

        public void Remove(string name)
        {
            int i = 0;
            while (i < Animals.Length &&
        (Animals[i] == null || Animals[i].Name != name))
            {
                i++;
            }
            if (i < Animals.Length)
            {
                Animals[i] = null;
            }
        }

        public int TypeNum(Animal_type type)
        {
            int num = 0;

            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i] != null &&
                    Animals[i].Type == type)
                {
                    num++;
                }
            }

            return num;
        }

        public bool TypeAndGender(Animal_type type, bool gender)
        {
            int num = 0;

            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i] != null &&
                    Animals[i].Type == type &&
                    Animals[i].Gender == gender)
                {
                    num++;
                }
            }

            return num > 0;
        }

        public Animal[] TypeAnimals(Animal_type type)
        {
            Animal[] type_animals = new Animal[TypeNum(type)];
            int j = 0;

            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i] != null &&
                    Animals[i].Type == type)
                {
                    type_animals[j] = Animals[i];
                    j++;
                }
            }

            return type_animals;
        }

        public float TypeAvgWeight(Animal_type type)
        {
            Animal[] type_animals = TypeAnimals(type);
            int sum = 0;
            for (int i = 0; i < type_animals.Length; i++)
            {
                sum += type_animals[i].Weight;
            }
            return sum / type_animals.Length;
        }
    }
}
