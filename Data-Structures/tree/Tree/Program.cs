using System;
using Tree.Classes;
using System.Collections.Generic;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree!");

            BinaryTree myTree = new BinaryTree(1);
            myTree.root.Left = new Node(2);
            myTree.root.Right = new Node(3);
            myTree.root.Left.Left = new Node(4);
            myTree.root.Left.Right = new Node(5);

            List<int> PreOrderList = new List<int>();
            List<int> InOrderList = new List<int>();
            List<int> PostOrderList = new List<int>();

            myTree.PreOrder(myTree.root, PreOrderList);

            /// <summary>
            /// Pre-order tree traversal
            /// </summary>
            foreach (int val in PreOrderList)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine("Print PreOrder data traversal  values");

            /// <summary>
            /// In-order tree traversal
            /// </summary>
            myTree.InOrder(myTree.root, InOrderList);
            foreach (int val in InOrderList)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine("Print InOrder data traversal  values");

            /// <summary>
            /// Post-order tree traversal
            /// </summary>
            myTree.PostOrder(myTree.root, PostOrderList);
            foreach (int val in PostOrderList)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine("Print PostOrder data traversal values");

            Console.WriteLine();
            int[] bstValues = { 1, 2, 3, 4, 5 };

            /// <summary>
            /// Print values of binary search tree
            /// </summary>
            BinarySearchTree BST = new BinarySearchTree();
            foreach (int num in bstValues)
            {
               BST.root = BST.Add(BST.root, num);
            }

            List<int> bstInOrder = new List<int>();
            BST.InOrder(BST.root, bstInOrder);

            foreach (int num in bstInOrder)
            {
                Console.Write($"{num}");
            }
            Console.WriteLine(" Binary Search Tree InOrder data traversal values");
        }
    }
}
