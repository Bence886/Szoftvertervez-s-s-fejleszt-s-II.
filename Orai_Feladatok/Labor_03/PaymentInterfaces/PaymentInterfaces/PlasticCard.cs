using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentInterfaces
{
    class PlasticCard : IProperty
    {
        string owner;

        public PlasticCard(string owner)
        {
            this.owner = owner;
        }

        public string Owner {
            get => owner;
            set => owner = value;
        }
    }
}
