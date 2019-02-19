using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(bool hollow, int color, double h, double w) : base(hollow, color)
        {
            height = h;
            width = w;
        }

        double height;
        double width;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public override double Area()
        {
            return Height* Width;
        }

        public override double Perimeter()
        {
            return 2 * (Height + Width);
        }

        public override string ToString()
        {
            return $"Rectangle: Height: {height}, Width: {width}" + base.ToString();
        }
    }
}
