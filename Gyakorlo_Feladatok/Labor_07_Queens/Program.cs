using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime start = DateTime.Now;
            Console.CursorVisible = false;
            QueensSolver qs = new QueensSolver(8);
            qs.Start();

            qs.PrintBoard();
            // Console.WriteLine($"Time: {(DateTime.Now-start).TotalMilliseconds}");
            Console.ReadKey();
        }
    }
}
