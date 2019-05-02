using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasitotabla
{
    abstract class Hasitotablazat<K, T>
    {
        int m;

        public abstract void Beszuras(K kulcs, T ertek);
        public abstract T Kereses(K kulcs);

        public Hasitotablazat(int elemszam)
        {
            m = elemszam;
        }
        protected int h(K kulcs)
        {
            return Math.Abs(kulcs.GetHashCode() % m);
        }
    }
}
