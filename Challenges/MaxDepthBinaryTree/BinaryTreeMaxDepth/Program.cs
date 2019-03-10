using System;
using Tree;
using Tree.Classes;

namespace BinaryTreeMaxDepth
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree BST = new BinarySearchTree();
            BST.root = BST.Add(BST.root, 10);
            BST.root = BST.Add(BST.root, 15);
            BST.root = BST.Add(BST.root, 5);
            BST.root = BST.Add(BST.root, 8);
            BST.root = BST.Add(BST.root, 12);
            BST.root = BST.Add(BST.root, 19);
            Console.WriteLine(MaxDepth(BST.root));
        }


        public static int MaxDepth(Node root)
        {
            if (root == null) return 0;
            else
            {
                int LeftDepth = MaxDepth(root.Left);
                int RightDepth = MaxDepth(root.Right);

                return (Math.Max(LeftDepth, RightDepth)+1);
            }      
        }
        
    }
}
