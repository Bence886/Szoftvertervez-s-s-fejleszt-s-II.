using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentInterfaces
{
    class BankCard : PlasticCard, IPayingTool
    {
        int sum;
        public BankCard(string owner, int sum) 
            : base(owner)
        {
            this.sum = sum;
        }

        public virtual bool Pay(int val)
        {
            sum -= val;
            return sum > 0;
        }
    }
}
