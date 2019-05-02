using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasitotabla
{
    class HasitoTablazatLancoltListaval<K, T> : Hasitotablazat<K, T>
    {
        class HasitoElem
        {
            public K kulcs;
            public T tartalma;
            public HasitoElem kovetkezo;
        }

        HasitoElem[] hasitoElemek;

        public HasitoTablazatLancoltListaval(int elemszam) : base(elemszam)
        {
            hasitoElemek = new HasitoElem[elemszam];
        }

        public override void Beszuras(K kulcs, T ertek)
        {
            HasitoElem ujElem = new HasitoElem();
            ujElem.kulcs = kulcs;
            ujElem.tartalma = ertek;
            if (hasitoElemek[h(kulcs)] == null)
            {
                hasitoElemek[h(kulcs)] = ujElem;
            }
            else
            {
                ujElem.kovetkezo = hasitoElemek[h(kulcs)];
                hasitoElemek[h(kulcs)] = ujElem;
            }
        }

        public override T Kereses(K kulcs)
        {
            HasitoElem akt = hasitoElemek[h(kulcs)];
            while (akt != null && !akt.kulcs.Equals(kulcs))
            {
                akt = akt.kovetkezo;
            }
            if (akt == null)
            {
                throw new Exception("Nincs ilyen elem!");
            }
            else
            {
                return akt.tartalma;
            }

        }
    }
}
