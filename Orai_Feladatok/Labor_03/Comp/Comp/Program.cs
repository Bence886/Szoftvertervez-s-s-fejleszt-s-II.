using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] nums = { 65464, 78 ,987, 1, 2, 7, 8, 9};
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + ", ");
            }
            Console.WriteLine();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + ", ");
            }
            */

            User[] users = {
                new User("Bence", 10, 180),
                new User("Máté", 50, 165),
                new User("Pista", 32, 140),
                new User("Béla", 23, 200)
            };

            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i].ToString());
            }
            Console.WriteLine();

            Array.Sort(users);
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i].ToString());
            }
        }
    }

    class User : IComparable
    {
        public User(string name, int age, int height)
        {
            Name = name;
            Age = age;
            Height = height;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public int CompareTo(object obj)
        {
            /*
                this > obj = 1
                this == obj = 0
                this < obj = -1
            */

            /*if (obj is User)
             * {User other = obj as User; ...}*/
            // User other = (User)obj;
            User other = obj as User;
            /*if (other == null)
            {
                // Hibakezelés
            }*/

            if (Age < other.Age)
            {
                return -1;
            }
            else if (Age == other.Age)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            // return Age - other.Age;
            // return Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return $"Name:{Name}, Age:{Age}, Height:{Height}";
        }
    }
}
