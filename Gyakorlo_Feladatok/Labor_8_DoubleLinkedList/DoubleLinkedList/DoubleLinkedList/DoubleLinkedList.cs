using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class DoubleLinkedList<T> : IEnumerable<T> where T : IComparable
    {
        public DoubleLinkedList()
        {

        }
        class ListElement
        {
            public T value;
            public ListElement next;
            public ListElement previous;
        }

        ListElement front;
        ListElement back;

        public void PushFront(T value)
        {
            ListElement newElement = new ListElement();
            newElement.value = value;

            if (back == null)
            {
                back = newElement;
            }
            else
            {
                front.previous = newElement;
            }

            newElement.next = front;
            front = newElement;
        }

        public void PushBack(T value)
        {
            ListElement newElement = new ListElement();
            newElement.value = value;

            if (front == null)
            {
                back = newElement;
                front = back;
            }
            else
            {

                newElement.previous = back;
                back.next = newElement;
                back = newElement;
            }
        }

        public void InsertInOrder(T value)
        {
            // ;)
        }

        public void Remove(T value)
        {
            ListElement p = front;
            ListElement e = null;
            while (p != back && !p.value.Equals(value))
            {
                e = p;
                p = p.next;
            }
            if (p != back)
            {
                if (e == null)
                {
                    front = front.next;
                }
                else
                {
                    e.next = p.next;
                    p = e;
                }
            }
            else if (back.value.Equals(value))
            {
                back = back.previous;
            }
        }

        public void DebugPrint()
        {
            ListElement p = front;
            while (p != null)
            {
                Console.WriteLine(p.value);
                p = p.next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ForwardListiterator(front);
            // return new BackwardIterator(back);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        class BackwardIterator : IEnumerator<T>
        {
            ListElement back;
            ListElement akt;

            public BackwardIterator(ListElement back)
            {
                this.back = back;
                akt = null;
            }

            public T Current => akt.value;

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
                back = null;
                akt = null;
            }

            public bool MoveNext()
            {
                if (akt == null)
                {
                    akt = back;
                }
                else
                {
                    akt = akt.previous;
                }
                return akt != null;
            }

            public void Reset()
            {
                akt = null;
            }
        }

        class ForwardListiterator : IEnumerator<T>
        {
            ListElement front;
            ListElement akt;

            public ForwardListiterator(ListElement front)
            {
                this.front = front;
                akt = null;
            }

            public T Current => akt.value;

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
                front = null;
                akt = null;
            }

            public bool MoveNext()
            {
                if (akt == null)
                {
                    akt = front;
                }
                else
                {
                    akt = akt.next;
                }
                return akt != null;
            }

            public void Reset()
            {
                akt = null;
            }
        }
    }
}
