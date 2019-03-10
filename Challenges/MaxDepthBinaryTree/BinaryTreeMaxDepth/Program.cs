using System;
using Tree;
using Tree.Classes;

namespace BinaryTreeMaxDepth
{
    public class Program
    {
        /// <summary>
        /// Run the MaxDepth on the main method
        /// </summary>
        /// <param name="args"></param>
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

        /// <summary>
        /// Calculate the max depth of the binary tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaxDepth(Node root)
        {
            // if root is null retun 0
            if (root == null) return 0;
            else
            {
                // recursively run the method on the left side and the right side
                int LeftDepth = MaxDepth(root.Left);
                int RightDepth = MaxDepth(root.Right);

                //return max depth of the tree
                return (Math.Max(LeftDepth, RightDepth)+1);
            }      
        }
        
    }
}
