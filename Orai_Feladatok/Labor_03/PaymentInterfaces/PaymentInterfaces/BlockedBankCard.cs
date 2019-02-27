using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentInterfaces
{
    class BlockedBankCard : BankCard, ILost
    {

        public BlockedBankCard(string owner, int sum, DateTime lostTime) 
            : base(owner, sum)
        {
            LostTime = lostTime;
        }
        DateTime lostTime;
        public DateTime LostTime {
            get => lostTime;
            set => lostTime = value;
        }
        
        public override bool Pay(int val)
        {
            return false;
        }
    }
}
