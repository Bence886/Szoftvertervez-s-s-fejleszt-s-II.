using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyakorlo
{
    class Worker
    {
        public Worker(string name, int salary)
        {
            Name = name;
            Wage = salary;
        }

        public string Name { get; set; }
        public int Wage { get; private set; }
        public int Hours { get; set; }
        public string Address { get; set; }

        public int Salary()
        {
            return Hours * Wage;
        }

        public override string ToString()
        {
            return string.Format("Name:{0}, Wage:{1}, Hours{2}", Name, Wage, Hours);
        }
    }
}
