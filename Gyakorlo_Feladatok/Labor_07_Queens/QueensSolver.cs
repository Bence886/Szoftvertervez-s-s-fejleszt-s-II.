using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Queens
{
    class QueensSolver
    {
        int N;
        int[] positions;
        public QueensSolver(int boardSize)
        {
            this.N = boardSize;
        }

        public void Start()
        {
            int[] positions = new int[N];
            bool DONE = false;
            BackTrack(0, ref DONE, positions);
            this.positions = positions;
        }

        private void BackTrack(int level, ref bool DONE, int[] positions)
        {
            int i = 0;
            do
            {
                /* Uncomment for step by step draw */
                // positions[level] = i;
                // PrintBoard(positions, level + 1);
                // Thread.Sleep(50);
                if (!Hit(i, positions, level))
                {
                    positions[level] = i;
                    if (level == N - 1)
                    {
                        DONE = true;
                    }
                    else
                    {
                        BackTrack(level + 1, ref DONE, positions);
                    }
                }
                i++;
            } while (!DONE && i < N * N);
        }

        private bool Hit(int pos, int[] positions, int level)
        {
            for (int i = 0; i < level; i++)
            {
                if ((pos == positions[i]) || RowHit(pos, positions[i]) || ColHit(pos, positions[i]) || DiagHit(pos, positions[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private bool DiagHit(int newPos, int oldPos)
        {
            int x_1 = newPos / N;
            int y_1 = newPos % N;
            int x_2 = oldPos / N;
            int y_2 = oldPos % N;

            return Math.Abs(x_1 - x_2) == Math.Abs(y_2 - y_1);

        }

        private bool ColHit(int newPos, int oldPos)
        {
            return newPos % N == oldPos % N;
        }

        private bool RowHit(int newPos, int oldPos)
        {
            return newPos / N == oldPos / N;
        }

        public void PrintBoard()
        {
            PrintBoard(positions, N);
        }

        void PrintBoard(int[] positions, int level)
        {
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            ClearBoard();
            PrintQueens(positions, level);
            Console.CursorTop = N + 1;
            Console.CursorLeft = 0;
            Console.WriteLine($"Num: {level}");
        }

        private void ClearBoard()
        {
            bool change = false;
            Console.Clear();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (change)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    change = !change;
                    Console.Write(" ");
                }
                change = !change;
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }

        private void PrintQueens(int[] positions, int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.CursorLeft = positions[i] % N;
                Console.CursorTop = positions[i] / N;
                Console.Write(i+1);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
        }

    }
}
