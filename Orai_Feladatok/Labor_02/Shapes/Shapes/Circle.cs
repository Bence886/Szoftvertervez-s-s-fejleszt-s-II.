using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        public Circle(bool hollow, int color, double rad) : base(hollow, color)
        {
            Radius = rad;
        }

        double radius;
        public double Radius { get => radius; set => radius = value; }

        public override double Area()
        {
            return radius * radius * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * radius * Math.PI; 
        }

        public override string ToString()
        {
            return $"Circle: Radius: {radius} " + base.ToString();
        }
    }
}
