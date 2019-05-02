using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    class Program
    {
        static SzomszedsagiLista szl;
        static CsucsMatrix csm;
        static void Main(string[] args)
        {
            /*GrafGen(5000, 50000);
            DateTime start = DateTime.Now;
            szl.SzelessegiBejaras(0);
            Console.WriteLine($"Szomszedsagi Lista: {(DateTime.Now - start).TotalMilliseconds}");

            start = DateTime.Now;
            csm.SzelessegiBejaras(0);
            Console.WriteLine($"Csúcs Mátrix :{(DateTime.Now - start).TotalMilliseconds}");
            */

            SzomszedsagiLista csm = new SzomszedsagiLista(4);
            csm.ElFelvetel(0, 1);
            csm.ElFelvetel(1, 2);
            csm.ElFelvetel(0, 3);
            csm.MelysegiBejaras(0);
        }

        static void GrafGen(int meret, int suruseg)
        {
            Random rnd = new Random();
            csm = new CsucsMatrix(meret);
            szl = new SzomszedsagiLista(meret);
            for (int i = 0; i < suruseg; i++)
            {
                int honnan = rnd.Next(0, meret);
                int hova = rnd.Next(0, meret);
                csm.ElFelvetel(honnan, hova);
                szl.ElFelvetel(honnan, hova);
            }
        }
    }
}
