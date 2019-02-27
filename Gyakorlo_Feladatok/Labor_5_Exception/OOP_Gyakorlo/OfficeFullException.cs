using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyakorlo
{
    class OfficeFullException : ApplicationException
    {
        object worker;

        public OfficeFullException(string message, object exceptionSender) : base(message)
        {
            this.Worker = exceptionSender;
        }

        public object Worker { get => worker; private set => worker = value; }
    }
}
