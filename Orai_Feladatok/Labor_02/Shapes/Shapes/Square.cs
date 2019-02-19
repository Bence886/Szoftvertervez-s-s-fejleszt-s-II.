using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Rectangle
    {
        public Square(bool hollow, int color, double size) : base(hollow, color, size, size)
        {
        }

        public override string ToString()
        {
            return "Square: " + base.ToString();
        }
    }
}
