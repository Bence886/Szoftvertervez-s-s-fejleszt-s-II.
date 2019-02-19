using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        protected Shape(bool hollow, int color)
        {
            this.hollow = hollow;
            this.Color = color;
        }

        bool hollow;
        int color;

        public int Color { get => color; set => color = value; }

        public abstract double Area();
        public abstract double Perimeter();

        public void MakeHollow()
        {
            hollow = true;
        }

        public override string ToString()
        {
            return $"Hollow: {hollow}, Color: {Color}";
        }
    }
}
