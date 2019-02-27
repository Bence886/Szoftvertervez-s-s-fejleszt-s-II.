using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPayingTool[] cards = {
                // new PlasticCard("Bence"),
                new BankCard("Bence", 10),
                new BlockedBankCard("Bence", 10, DateTime.Now),
                new Loan(10)
            };

            Console.WriteLine(Pay(cards, 1));
        }

        static bool Pay(IPayingTool[] cards, int val)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i].Pay(val))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
