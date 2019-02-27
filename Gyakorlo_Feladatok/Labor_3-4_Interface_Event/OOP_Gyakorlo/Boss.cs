using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyakorlo
{
    class Boss : Leader
    {
        public Boss(string name, int salary, int premium) : base(name, salary, premium)
        {
        }
        public void Company_newWorkerArrived(IWorking ujDolgozo)
        {
            ujDolgozo.DoWork("Munka");
        }
    }
}
