﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyakorlo
{
    class OfficeWorker : Worker, IWorking
    {
        public OfficeWorker(string name, int salary) : base(name, salary)
        {
        }

        public void DoWork(string munka)
        {
            Console.WriteLine("Az irodában dolgozok!");
        }
    }
}
