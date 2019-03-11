using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_1
{
    class Stack
    {
        private int dept;
        private int pointer;
        private int[] array;

        public Stack(int dept)
        {
            this.dept = dept;
            array = new int[dept];
        }

        public void Push(int val)
        {
            if (pointer < dept)
            {
                array[pointer] = val;
                pointer++;
            }
            else
            {
                throw new StackFullException(this, "Tele a verem", "Hozz létre nagyobbat vagy szabadíts fel benne helyet.");
            }
        }

        public int Pop()
        {
            if (pointer - 1 > 0) 
            {
                pointer--;
                return array[pointer];
            }
            else
            {
                throw new StackEmptyException("Üres a verem.", "tEGYÉL BELE VALAMIT!");
            }
        }

        public override string ToString()
        {
            string ret="";
            for (int i = 0; i < pointer; i++)
            {
                ret += array[i] + ", ";
            }
            return ret;
        }
    }

    class StackEmptyException : MyException
    {
        public StackEmptyException(string msg, string plusInfo) : base(msg, plusInfo)
        {
        }
    }
    class StackFullException : MyException
    {
        public Stack s;
        public StackFullException(Stack s, string msg, string plusInfo) : base(msg, plusInfo)
        {
            this.s = s;
        }
    }
    class MyException : ApplicationException
    {
        public MyException(string msg, string plusInfo) : base(msg)
        {
            PlusInfo = plusInfo;
        }
        public string PlusInfo { get; set; }
    }
}
