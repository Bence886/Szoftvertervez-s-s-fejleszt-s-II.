using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    abstract class GrafBase
    {
        public int N;

        public GrafBase(int n)
        {
            N = n;
        }

        public List<int> Szomszedok(int csucs)
        {
            List<int> szomszedok = new List<int>();
            List<int> csucsok = Csucsok();
            foreach (int item in csucsok)
            {
                if (VezetEl(csucs, item))
                {
                    szomszedok.Add(item);
                }
            }
            return szomszedok;
        }

        public void SzelessegiBejaras(int csucs)
        {
            List<int> F = new List<int>();
            Queue<int> S = new Queue<int>();

            S.Enqueue(csucs);
            F.Add(csucs);
            while (S.Count != 0)
            {
                int k = S.Dequeue();
                // Console.WriteLine(k);
                List<int> szomszedok = Szomszedok(k);
                foreach (int item in szomszedok)
                {
                    if (!F.Contains(item))
                    {
                        S.Enqueue(item);
                        F.Add(item);
                    }
                }
            }
        }

        public void MelysegiBejaras(int csucs)
        {
            List<int> F = new List<int>();
            MelysegiBejarasRek(csucs, F);
        }

        private void MelysegiBejarasRek(int csucs, List<int> F)
        {
            F.Add(csucs);
            Console.WriteLine(csucs);
            foreach (int item in Szomszedok(csucs))
            {
                if (!F.Contains(item))
                {
                    MelysegiBejarasRek(item, F);
                }
            }
        }

        public abstract List<int> Csucsok();
        public abstract bool VezetEl(int honnan, int hova);
        public abstract void ElFelvetel(int honnan, int hova);
    }
}
