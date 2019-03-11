using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_1_A
{
    class RewriteableTask : IRewriteable
    {
        public RewriteableTask(int maxPoints, string task, int maxRewrite)
        {
            MaxPoints = maxPoints;
            Task = task;
            MaxRewrite = maxRewrite;
        }

        public int MaxPoints { get; set; }
        public string Task { get; set; }
        public int MaxRewrite { get; set; }
        public DateTime LastWriteDate { get => lastRewrite; set => lastRewrite = value; }

        DateTime lastRewrite;

        string answer;

        public void Answer(string ans)
        {
            answer = ans;
        }

        public void Rewrite(string data)
        {
            lastRewrite = DateTime.Now;
            answer = data;
        }

        public override string ToString()
        {
            return $"{Task} {answer}, {lastRewrite}";
        }
    }
}
