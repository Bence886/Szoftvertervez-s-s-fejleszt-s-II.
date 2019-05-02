using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    class SzomszedsagiLista : GrafBase
    {
        List<int>[] L;
        public SzomszedsagiLista(int n) : base(n)
        {
            L = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                L[i] = new List<int>();
            }
        }

        public override List<int> Csucsok()
        {
            List<int> cs = new List<int>();
            for (int i = 0; i < L.Length; i++)
            {
                cs.Add(i);
            }
            return cs;
        }

        public override void ElFelvetel(int honnan, int hova)
        {
            L[honnan].Add(hova);
        }

        public override bool VezetEl(int honnan, int hova)
        {
            for (int i = 0; i < L[honnan].Count; i++)
            {
                if (L[honnan][i] == hova)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
