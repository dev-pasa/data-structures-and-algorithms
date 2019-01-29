using System;
using Tree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Tree: ");
            BinarySearchTree BST = new BinarySearchTree();
            BST.root = BST.Add(BST.root, 10);
            BST.root = BST.Add(BST.root, 15);
            BST.root = BST.Add(BST.root, 5);
            BST.root = BST.Add(BST.root, 8);
            BST.root = BST.Add(BST.root, 12);
            BST.root = BST.Add(BST.root, 19);
            Console.WriteLine("The value in binary search tree (pre-order traversal): 10, 15, 5, 8, 12, 19");
            Console.WriteLine("FizzBuzz Binary Search Tree PreOrderTraversal(): ");
            FizzBuzzTree(BST);

            Console.WriteLine();
            BinaryTree BT = new BinaryTree(5);
            BT.root.Left = new Node(11);
            BT.root.Left.Left = new Node(10);
            BT.root.Left.Right = new Node(15);
            BT.root.Right = new Node(12);
            BT.root.Right.Right = new Node(9);
            BT.root.Right.Left = new Node(17);
            Console.WriteLine("The value in binary tree (pre-order traversal): 5, 11, 10, 15, 12, 9, 17");
            Console.WriteLine("FizzBuzz Binary Tree PreOrderTraversal(): ");
            FizzBuzzTree(BT);
        }

        public static void FizzBuzzTree(BinaryTree tree)
        {
            PreOrderFizzBuzz(tree.root);
        }

        public static void PreOrderFizzBuzz(Node root)
        {
            if (root.Value % 15 == 0) Console.WriteLine("FizzBuzz");
            else if (root.Value % 3 == 0) Console.WriteLine("Fizz");
            else if (root.Value % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(root.Value);
            if (root.Left != null) PreOrderFizzBuzz(root.Left);
            if (root.Right != null) PreOrderFizzBuzz(root.Right);
        }

    }
}
