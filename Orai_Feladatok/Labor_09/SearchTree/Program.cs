using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEarchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> BST = new BinarySearchTree<int>();

            BST.Add(3);
            BST.Add(1);
            BST.Add(6);
            BST.Add(5);
            BST.Add(4);
            BST.Add(2);

            foreach (int item in BST.CostomOrder(walk_style.preorder))
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            foreach (int item in BST.CostomOrder(walk_style.inorder))
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            foreach (int item in BST.CostomOrder(walk_style.postorder))
            {
                Console.Write(item + ", ");
            }
        }
    }
}
