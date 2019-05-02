using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    class CsucsMatrix : GrafBase
    {
        int[,] CS;
        public CsucsMatrix(int n) : base(n)
        {
            CS = new int[n, n];
        }

        public override List<int> Csucsok()
        {
            List<int> csucsok = new List<int>();

            for (int i = 0; i < N; i++)
            {
                csucsok.Add(i);
            }

            return csucsok;
        }

        public override void ElFelvetel(int honnan, int hova)
        {
            CS[honnan, hova] = 1;
        }

        public override bool VezetEl(int honnan, int hova)
        {
            return CS[honnan, hova] != 0;
        }
    }
}
