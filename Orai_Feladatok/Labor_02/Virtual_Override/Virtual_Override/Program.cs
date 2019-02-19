using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(); // A ctor
            a.VirtualPrint(); // Virtual A
            a.HidePrint(); //Hide A

            Console.WriteLine();
            B b = new B(); // A ctor , B ctor
            b.VirtualPrint(); // Virtual B
            b.HidePrint(); // Hide B

            Console.WriteLine();
            A ab = new B(); // A ctor, B ctor
            ab.VirtualPrint(); // Virtual B
            ab.HidePrint(); // Hide A
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("A ctor");
            
        }

        public virtual void VirtualPrint()
        {
            Console.WriteLine("Virtual A");
        }

        public void HidePrint()
        {
            Console.WriteLine("Hide A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B ctor");
        }

        public override void VirtualPrint()
        {
            Console.WriteLine("Virtual B");
        }

        public void HidePrint()
        {
            Console.WriteLine("Hide B");
        }
    }
}
