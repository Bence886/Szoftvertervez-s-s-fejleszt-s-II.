using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyakorlo
{
    class Company
    {
        public Company(string name, int workerNum)
        {
            Name = name;
            WorkerNum = workerNum;
            Workers = new Worker[workerNum];
        }

        public string Name { get; set; }
        public int WorkerNum { get; set; }

        Worker[] Workers;

        public int SalarySum()
        {
            int sum = 0;

            for (int i = 0; i < WorkerNum; i++)
            {
                if (Workers[i] != null)
                {
                    sum += Workers[i].Salary();
                }
            }

            return sum;
        }

        public void HireWorker(Worker w)
        {
            int i = 0;
            while (i < WorkerNum && Workers[i] != null)
            {
                i++;
            }
            if (i < WorkerNum)
            {
                Workers[i] = w;
            }
        }

        public override string ToString()
        {
            string ret = "";

            for (int i = 0; i < WorkerNum; i++)
            {
                if (Workers[i] != null)
                {
                    ret += Workers[i].ToString() + "\t" + Workers[i].GetType() + '\n';
                }
            }

            return ret;
        }
    }
}
