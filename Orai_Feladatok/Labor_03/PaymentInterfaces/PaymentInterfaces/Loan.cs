using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentInterfaces
{
    class Loan : IPayingTool
    {
        int sum;

        public Loan(int sum)
        {
            this.sum = sum;
        }

        public bool Pay(int val)
        {
            if (sum - val >= 0)
            {
                sum -= val;
                return true;
            }
            return false;
        }
    }
}
