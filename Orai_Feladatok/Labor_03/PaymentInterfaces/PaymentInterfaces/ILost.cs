using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentInterfaces
{
    interface ILost : IProperty
    {
        DateTime LostTime { get; set; }
    }
}
