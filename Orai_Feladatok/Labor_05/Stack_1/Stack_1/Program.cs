using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(3);

            try
            {
                s.Push(1);
                s.Push(10);
                s.Push(4);
                Console.WriteLine(s.ToString());
                Console.WriteLine("Pop: " + s.Pop());
                Console.WriteLine(s.ToString());
                s.Push(2);
                //s.Push(3);
                s.Pop();
                s.Pop();
                s.Pop();
                s.Pop();
                s.Pop();
                s.Pop();
                s.Pop();
            }
            catch (StackFullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("ksadaofdjh");
        }
    }
}
