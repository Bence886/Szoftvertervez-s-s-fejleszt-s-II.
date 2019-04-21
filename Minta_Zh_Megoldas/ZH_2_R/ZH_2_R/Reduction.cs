using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH_2_R
{
    class Reduction<T>
    {
        public delegate T Operation(T p1, T p2);
        Node head;
        class Node
        {
            public T value;
            public Node next;
            public Node child;
        }

        private Operation operation;
        public void AddOperation(Operation operation)
        {
            this.operation = operation;
        }

        public void Add(T val)
        {
            Node newNode = new Node();
            newNode.value = val;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node p = head;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = newNode;
            }
        }

        public void Build()
        {
            PBuild(head);
        }

        private void LevelLink(Node n, Node nn)
        {
            if (n != nn)
            {
                Node p = n;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = nn;
            }
        }

        private void PBuild(Node n)
        {
            Node p = n;
            while (p != null)
            {
                Node newNode = new Node();
                if (p.next != null)
                {
                    newNode.value = operation(p.value, p.next.value);
                    p.child = newNode;
                    p.next.child = newNode;
                    p = p.next.next;
                }
                else
                {
                    newNode.value = p.value;
                    p.child = newNode;
                    p = p.next;
                }
                LevelLink(n.child, newNode);
            }
            if (n.child.next != null)
            {
                PBuild(n.child);
            }
        }

        public T GetResult()
        {
            return PGetResult(head);
        }

        private T PGetResult(Node n)
        {
            if (n.child !=null)
            {
                return PGetResult(n.child);
            }
            return n.value;
        }
    }
}
