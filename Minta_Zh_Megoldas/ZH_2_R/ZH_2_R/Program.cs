using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH_2_R
{
    class Program
    {
        static void Main(string[] args)
        {
            Reduction<int> r = new Reduction<int>();
            r.AddOperation(Sum);
            r.Add(3);
            r.Add(5);
            r.Add(2);
            r.Add(5);
            r.Add(4);
            r.Add(6);
            r.Build();
            Console.WriteLine(r.GetResult());
        }

        static int Sum(int p1, int p2)
        {
            return p1 + p2;
        }
    }
}
