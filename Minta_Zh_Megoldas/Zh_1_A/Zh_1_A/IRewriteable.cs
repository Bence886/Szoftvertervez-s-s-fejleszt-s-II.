using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_1_A
{
    interface IRewriteable
    {
        DateTime LastWriteDate { get; }
        void Rewrite(string data);
    }
}
