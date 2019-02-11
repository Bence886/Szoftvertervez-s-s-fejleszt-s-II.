using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cage c0 = new Cage(5);
            c0.Add(new Animal("Kormos", true, 10, Animal_type.dog));
            c0.Add(new Animal("Kormos_0", true, 10, Animal_type.dog));
            c0.Add(new Animal("Kormos_1", true, 125, Animal_type.bear));
            c0.Add(new Animal("Kormos_2", false, 1, Animal_type.cat));

            /*
            Console.WriteLine(c0.TypeNum(Animal_type.bear));
            Console.WriteLine(c0.TypeNum(Animal_type.cat));
            Console.WriteLine(c0.TypeNum(Animal_type.dog));
            */
            /*
            Console.WriteLine(c0.TypeAndGender(Animal_type.bear, false));
            Console.WriteLine(c0.TypeAndGender(Animal_type.bear, true));
            */

            // Animal[] anims = c0.TypeAnimals(Animal_type.bear);

            // Console.WriteLine(c0.TypeAvgWeight(Animal_type.dog));

            /*
            Cat c = new Cat("Kormos_21", true, 1);
            c.Meow();
            */

            /*
            Animal[] anims = new Animal[3];
            anims[0] = c;

            anims[1] = new Dog("Kormos_22", false, 10);

            (anims[1] as Dog).Bark(); // null
            ((Dog)anims[1]).Bark(); // invalid cast
            */

            Console.ReadKey();
        }
    }
}
