using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEarchTree
{
    enum walk_style
    {
        preorder, inorder, postorder
    }
    class BinarySearchTree<T> where T : IComparable<T>
    {
        class Node
        {
            public T value;
            public Node right;
            public Node left;
        }
        Node root;

        public bool Remove(T val)
        {
            return PrivateRemove(ref root, val);
        }

        private bool PrivateRemove(ref Node p, T val)
        {
            if (p == null)
            {
                return false;
            }
            int c = p.value.CompareTo(val);
            if (c < 0)
            {
                return PrivateRemove(ref p.right, val);
            }
            else if (c > 0)
            {
                return PrivateRemove(ref p.left, val);
            }
            else
            {
                if (p.left == null)
                {
                    p = p.right;
                }
                else if (p.right == null)
                {
                    p = p.left;
                }
                else
                {
                    RemoveCaseC(p, ref p.left);
                }
                return true;
            }
        }

        private void RemoveCaseC(Node p, ref Node left)
        {
            if (left.right != null)
            {
                RemoveCaseC(p, ref left.right);
            }
            else
            {
                p.value = left.value;
                left = left.left;
            }
        }

        public void Add(T val)
        {
            PrivateAdd(ref root, val);
        }

        private void PrivateAdd(ref Node p, T val)
        {
            if (p == null)
            {
                p = new Node();
                p.value = val;
            }
            else
            {
                int c = p.value.CompareTo(val);
                if (c < 0)
                {
                    PrivateAdd(ref p.right, val);
                }
                else if (c > 0)
                {
                    PrivateAdd(ref p.left, val);
                }
            }
        }

        public IEnumerable<T> WidthWalk()
        {
            List<T> list = new List<T>();
            Queue<Node> Q = new Queue<Node>();
            Q.Enqueue(root);

            while (Q.Count > 0)
            {
                Node p = Q.Dequeue();
                list.Add(p.value);
                if (p.left != null)
                {
                    Q.Enqueue(p.left);
                }
                if (p.right != null)
                {
                    Q.Enqueue(p.right);
                }
            }
            return list;
        }

        public IEnumerable<T> DeptWalk()
        {
            Stack<Node> S = new Stack<Node>();
            S.Push(root);
            while (S.Count > 0)
            {
                Node p = S.Pop();
                yield return p.value;
                if (p.left != null)
                {
                    S.Push(p.left);
                }
                if (p.right != null)
                {
                    S.Push(p.right);
                }
            }
        }

        public IEnumerable<T> CostomOrder(walk_style walk)
        {
            List<T> list = new List<T>();
            PrivateCustomOrder(root, walk, list);
            return list;
        }

        private void PrivateCustomOrder(Node p, walk_style walk, List<T> list)
        {
            if (p != null)
            {

                if (walk == walk_style.preorder)
                {
                    list.Add(p.value);
                }

                PrivateCustomOrder(p.left, walk, list);

                if (walk == walk_style.inorder)
                {
                    list.Add(p.value);
                }

                PrivateCustomOrder(p.right, walk, list);

                if (walk == walk_style.postorder)
                {
                    list.Add(p.value);
                }
            }
        }
    }
}
