using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasitotabla
{
    class Program
    {
        static void Main(string[] args)
        {
            HasitoTablazatLancoltListaval<int, int> hashtable = new HasitoTablazatLancoltListaval<int, int>(10);

            hashtable.Beszuras(1, 1);
            hashtable.Beszuras(3, 3);
            hashtable.Beszuras(2, 4);

            Console.WriteLine(hashtable.Kereses(1));
            
        }
    }

    class Hallgato
    {
        string name;
        string neptunCode;

        List<int> mark;

        public Hallgato(string name, string neptunCode)
        {
            this.Name = name;
            this.NeptunCode = neptunCode;
        }

        public string Name { get => name; set => name = value; }
        public string NeptunCode { get => neptunCode; set => neptunCode = value; }

        public void AddMark(int i)
        {
            if (i > 5 || i < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            mark.Add(i);
        }

        public override bool Equals(object obj)
        {
            if (obj is Hallgato)
            {
                Hallgato other = obj as Hallgato;
                return other.name == name && other.neptunCode == neptunCode;
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = 24168656;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(neptunCode);
            return hashCode;
        }
    }


}
