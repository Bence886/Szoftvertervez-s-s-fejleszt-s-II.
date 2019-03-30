using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog2_06_3_Sudoku
{
    class Pozicio
    {
        int row;

        public int Sor
        {
            get { return row; }
            set { row = value; }
        }

        int column;

        public int Oszlop
        {
            get { return column; }
            set { column = value; }
        }

        public Pozicio(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public static bool Kizaroak(Pozicio p1, Pozicio p2)
        {
            return (p1.Sor == p2.Sor ||
                    p1.Oszlop == p2.Oszlop ||
                    (p1.Sor / 3 == p2.Sor / 3 && p1.Oszlop / 3 == p2.Oszlop / 3));
        }
    }

    class Program
    {
        static int[,] ExampleTable_0()
        {
            int[,] example = new int[3, 3] {
                {0,1,3},
                {5,0,7},
                {9,0,0}};
            return example;
        }

        static int[,] ExampleTable_1()
        {
            int[,] example = new int[9, 9] {
                {5,3,0,0,7,0,0,0,0},
                {6,0,0,1,9,5,0,0,0},
                {0,9,8,0,0,0,0,6,0},
                {8,0,0,0,6,0,0,0,3},
                {4,0,0,8,0,3,0,0,1},
                {7,0,0,0,2,0,0,0,6},
                {0,6,0,0,0,0,2,8,0},
                {0,0,0,4,1,9,0,0,5},
                {0,0,0,0,8,0,0,7,9}};
            return example;
        }

        static int[,] ExampleTable_2()
        {
            int[,] example = new int[9, 9] {
                {0,2,8,5,0,9,0,7,6},
                {3,0,0,0,0,6,0,0,8},
                {0,0,0,8,0,0,5,0,0},
                {0,0,0,0,0,0,0,0,0},
                {1,0,7,0,0,0,2,0,0},
                {0,0,0,1,0,0,7,0,0},
                {0,3,0,6,0,0,0,0,0},
                {0,8,6,7,0,5,1,2,0},
                {0,5,0,2,0,8,0,3,0}};
            return example;
        }

        static void DrawTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    Console.Write((table[i, j] == 0 ? "." : table[i, j].ToString()) + " ");
                Console.WriteLine(); Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] table = ExampleTable_1();

            Console.WriteLine("Task:");
            DrawTable(table);

            Console.WriteLine("Solution:");
            SudokuSolver solver = new SudokuSolver(table);
            if (solver.MegoldastKeres())
                DrawTable(table);
            else
                Console.WriteLine("No solution found");

            Console.ReadKey();
        }
    }

    partial class SudokuSolver
    {
        int[,] tabla;

        public int[,] Table
        {
            get { return tabla; }
            set
            {
                tabla = value;
                CreatePositions();
            }
        }

        public SudokuSolver(int[,] table)
        {
            Table = table;
        }

        void CreatePositions()
        {
            int DB = 0;
            for (int i = 0; i < tabla.GetLength(0); i++)
                for (int j = 0; j < tabla.GetLength(1); j++)
                    if (tabla[i, j] != 0) DB++;

            fixMezok = new Pozicio[DB];
            N = tabla.GetLength(0) * tabla.GetLength(1) - DB;
            uresMezok = new Pozicio[N];

            int DBF = 0; int DBU = 0;
            for (int i = 0; i < tabla.GetLength(0); i++)
                for (int j = 0; j < tabla.GetLength(1); j++)
                    if (tabla[i, j] != 0)
                        fixMezok[DBF++] = new Pozicio(i, j);
                    else
                        uresMezok[DBU++] = new Pozicio(i, j);
        }

        void CombineTableWithSolution(int[] E)
        {
            for (int i = 0; i < uresMezok.Length; i++)
                tabla[uresMezok[i].Sor, uresMezok[i].Oszlop] = E[i];
        }

        Pozicio[] fixMezok;
        Pozicio[] uresMezok;
        int N;

        public bool MegoldastKeres()
        {
            bool VAN = false;
            int[] E = new int[N];

            BackTrack(0, ref VAN, E);

            if (VAN) CombineTableWithSolution(E);
            return VAN;
        }
        /*
         szint = keresett elem szorszáma
         VAN = megtaláltuk az eredményt
         E = Részmegoldás
         i = a szám amit próbálunk beírni
        */
        private void BackTrack(int szint, ref bool VAN, int[] E)
        {
            int i = 0;
            do
            {
                i++;
                /*eredetiekhez képest*/
                if (ft(szint, i))
                {
                    int k = 0;
                    while (k < szint && fk(szint, i, k, E[k]))
                    {
                        k++;
                    }
                    if (k == szint)
                    {
                        E[szint] = i;
                        if (szint == N - 1)
                        {
                            VAN = true;
                        }
                        else
                        {
                            BackTrack(szint + 1, ref VAN, E);
                        }
                    }
                }
            } while (!VAN && i < 9);
        }

        // szint = hova
        // i = mit
        // k = k.előző
        // kszam k.előző értéke
        private bool fk(int szint, int i, int k, int kszam)
        { // általunk beírtak szerint vizsgál
            return !(i == kszam &&
                Pozicio.Kizaroak(uresMezok[szint], uresMezok[k]));
        }

        // szint = hely
        private bool ft(int szint, int szam)
        { // az eredeti értékekhez képest vizsgál
            int i = 0;
            while (i < fixMezok.Length && 
                !(tabla[fixMezok[i].Sor, fixMezok[i].Oszlop] == szam &&
                Pozicio.Kizaroak(fixMezok[i], uresMezok[szint]))
                )
            {
                i++;
            }
            return !(i < fixMezok.Length);
        }
    }
}
