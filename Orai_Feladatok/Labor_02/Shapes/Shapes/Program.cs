using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[5];
            // shapes[0] = new Shape();     // abstract nem példányosítható
            shapes[0] = new Circle(false, 0xFFFFFF, 10);
            shapes[1] = new Circle(true, 0x000000, 25);
            shapes[2] = RectangleFactory(50, 25);
            shapes[3] = RectangleFactory(100, 100);
            shapes[4] = RectangleFactory(10, 20);

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i].ToString());

                // MakeShapeHollow(shapes[i]);

                // Console.WriteLine(shapes[i].ToString());
            }

            Console.WriteLine();
            Console.WriteLine("======= Biggest Area =======");

            Console.WriteLine(BiggestArea(shapes).ToString());
        }

        static void MakeShapeHollow(Shape s)
        {
            if (s.Area() > s.Perimeter())
            {
                s.MakeHollow();
            }
        }

        // Abstract Factory
        static Rectangle RectangleFactory(double w, double h)
        {
            if (h == w)
            {
                return new Square(false, 0xFFFFFF, h);
            }
            else
            {
                return new Rectangle(false, 0xFFFFFF, h, w);
            }
        }

        static Shape BiggestArea(Shape[] shapes)
        {
            int max_id = 0;

            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i].Area() > shapes[max_id].Area())
                {
                    max_id = i;
                }
            }

            return shapes[max_id];
        }
    }
}
