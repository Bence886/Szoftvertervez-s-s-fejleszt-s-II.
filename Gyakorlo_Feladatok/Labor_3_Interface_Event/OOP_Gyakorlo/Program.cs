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
            Company c = new Company("E-Corp", 10, new Boss("Mester", 1000, 1000));

            for (int i = 0; i < 2; i++)
            {
                c.HireWorker(new OfficeWorker("Worker_" + i, rnd.Next(10, 20)));
                c.HireWorker(new StudentWorker("Student_" + i, rnd.Next(10, 20), "OE-NIK"));
                c.HireWorker(new Leader("Worker_" + i, rnd.Next(), 200));
            }
            
            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}
