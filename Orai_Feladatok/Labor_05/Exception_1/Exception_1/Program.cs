using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyException("Hiba!");
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("asd");
            }
        }
    }

    class MyException : ApplicationException
    {
        public MyException(string message) : base(message)
        {
        }
    }
}
