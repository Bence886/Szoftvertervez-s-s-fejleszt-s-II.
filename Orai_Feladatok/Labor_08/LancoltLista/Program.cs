using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancoltLIsta
{
    class Program
    {
        static void Main(string[] args)
        {
            LancoltLista<int> ll = new LancoltLista<int>();
            ll.VegereBeszuras(1);
            ll.VegereBeszuras(2);
            ll.VegereBeszuras(3);
            ll.VegereBeszuras(4);
            ll.VegereBeszuras(5);
            ll.Torles(3);
            // ll.Bejaro(Kiiras);

            foreach (int item in ll)
            {
                Console.WriteLine(item);
            }

           //LancoltLista<Diak> ll = new LancoltLista<Diak>();
           //Diak diak = new Diak("a", 1);
           //ll.VegereBeszuras(new Diak("a", 1));
           //ll.VegereBeszuras(new Diak("b", 2));
           //ll.VegereBeszuras(new Diak("c", 3));
           //ll.VegereBeszuras(new Diak("d", 4));
           //ll.Torles(diak);
           //ll.Bejaro(Kiiras);

        }
        static void Kiiras(Diak val)
        {
            Console.WriteLine(val);
        }
        static void Kiiras(int val)
        {
            Console.WriteLine(val);
        }
    }

    class Diak
    {
        public Diak(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            Diak other = obj as Diak;
            return Name == other.Name && Age == other.Age;
        }

        public override string ToString()
        {
            return $"Name:{Name}, Age: {Age}";
        }
    }
}
