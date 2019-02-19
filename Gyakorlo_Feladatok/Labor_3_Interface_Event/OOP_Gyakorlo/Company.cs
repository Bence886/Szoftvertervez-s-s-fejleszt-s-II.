using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Gyakorlo
{
    delegate void NewWorker(IWorking newWorker);
    class Company
    {
        event NewWorker newWorkerArrived;
        public Company(string name, int workerNum, Boss boss)
        {
            Name = name;
            WorkerNum = workerNum;
            Workers = new Worker[workerNum];
            this.boss = boss;
            newWorkerArrived += Boss.Company_newWorkerArrived;
        }

        public string Name { get; set; }
        public int WorkerNum { get; set; }
        public Boss Boss { get => boss; set => boss = value; }

        Worker[] Workers;
        Boss boss;

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
                if (w is IWorking)
                {
                    newWorkerArrived(w as IWorking);
                }
            }
        }

        public override string ToString()
        {
            string ret = "";

            for (int i = 0; i < WorkerNum; i++)
            {
                if (Workers[i] != null)
                {
                    ret += Workers[i].ToString() + "  " + Workers[i].GetType() + '\n';
                }
            }

            return ret;
        }
    }
}
