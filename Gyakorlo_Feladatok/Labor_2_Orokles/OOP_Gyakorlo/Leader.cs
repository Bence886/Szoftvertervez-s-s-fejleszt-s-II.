using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyakorlo
{
    class Leader : Worker
    {
        public Leader(string name, int salary, int premium) : base(name, salary)
        {
            Premium = premium;
        }

        public int Premium { get; private set; }

        public override int Salary()
        {
            return base.Salary() + Premium;
        }
    }
}
