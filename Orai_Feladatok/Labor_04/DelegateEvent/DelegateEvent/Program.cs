using System;

namespace DelegateEsemeny
{
    public delegate double Kozvetito(double szam);
    class Program
    {
        static void Main(string[] args)
        {
            Kozvetito teszt = new Kozvetito(Muveletek.Ketszerezes);
            //Kozvetito teszt = Muveletek.Ketszerezes;

            Console.WriteLine(teszt(5));

            SzovegFeldolgozo feldolgozo = Muveletek.NagyKiir;
            feldolgozo += Muveletek.KisKiir;
            feldolgozo("Teszt Szöveg!");

            Szamolo szamolo = new Szamolo();
            szamolo.figyelo += Szamolo_figyelo;
            szamolo.Szam = 10;
        }

        private static void Szamolo_figyelo(int szamErtek)
        {
            Console.WriteLine(szamErtek);
        }
    }
    static class Muveletek
    {
        public static double Ketszerezes(double szam)
        {
            return szam * szam;
        }
        public static void NagyKiir(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
        public static void KisKiir(string s)
        {
            Console.WriteLine(s.ToLower());
        }
    }
    delegate void SzovegFeldolgozo(string szoveg);

    public delegate void SzamValtozott(int szamErtek);
    class Szamolo
    {
        public event SzamValtozott figyelo;
        int szam;
        public int Szam
        {
            set {
                szam = value;
                if (figyelo != null)
                {
                    figyelo(szam);
                }
            }
        }
    }
}