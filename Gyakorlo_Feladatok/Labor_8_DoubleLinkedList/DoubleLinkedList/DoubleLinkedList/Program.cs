using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
            dll.PushBack(1);
            dll.PushBack(2);
            dll.PushBack(3);
            dll.PushFront(0);
            dll.Remove(2);

            foreach (var item in dll)
            {
                Console.WriteLine(item);
            }
        }
    }
}
