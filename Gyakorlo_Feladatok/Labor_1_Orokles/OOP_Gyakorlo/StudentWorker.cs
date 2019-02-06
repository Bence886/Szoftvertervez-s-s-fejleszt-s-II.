using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyakorlo
{
    sealed class StudentWorker : Worker
    {
        public string School { get; set; }
        public StudentWorker(string name, int salary, string shc) : base(name, salary)
        {
            School = shc;
        }

        public override int Salary()
        {
            return (int)(base.Salary() * 0.95);
        }
    }
}
