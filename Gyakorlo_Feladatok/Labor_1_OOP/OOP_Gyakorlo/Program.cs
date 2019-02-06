using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyakorlo
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Company c = new Company("E-Corp", 10);

            for (int i = 0; i < 10; i++)
            {
                Worker w = new Worker("Worker_" + i, rnd.Next(100, 200));
                w.Hours = rnd.Next(20, 30);
                c.HireWorker(w);
            }

            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}
