using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_1_A
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalDataStorage[] DDS = new DigitalDataStorage[5];
            DDS[0] = new DigitalDataStorage(1);
            DDS[1] = new DigitalDataStorage(2);
            DDS[2] = new RewriteableDataStorage(3);
            DDS[3] = new RewriteableDataStorage(4);
            DDS[4] = new RewriteableDataStorage(5);

            for (int i = 0; i < DDS.Length; i++)
            {
                DDS[i].StorageFullEvent += Program_StorageFullEvent;
                try
                {
                    for (int k = 0; k < 4; k++)
                    {
                        DDS[i].Write("asd" + i + " : " + k);
                    }
                }
                catch (NoStorageSpace e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            IRewriteable[] IR = new IRewriteable[5];
            int j = 0;
            for (int i = 0; i < DDS.Length; i++)
            {
                if (DDS[i] is IRewriteable && j < IR.Length)
                {
                    IR[j] = DDS[i] as IRewriteable;
                    j++;
                }
            }
            for (int i = j; i < IR.Length; i++)
            {
                IR[i] = new RewriteableTask(1, "Todo", i);
            }
            for (int i = 0; i < IR.Length; i++)
            {
                IR[i].Rewrite("asd");
                IR[i].Rewrite("asd");
                IR[i].Rewrite("asd");
                IR[i].Rewrite("asd");
                IR[i].Rewrite("asd");
                IR[i].Rewrite("asd");
            }
        }

        private static void Program_StorageFullEvent(DigitalDataStorage s)
        {
            Console.WriteLine(s.ToString() + "tele.");
        }
    }
}
