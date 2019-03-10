using System;
using Tree;
using Tree.Classes;

namespace BinaryTreeHeight
{
    public class Program
    {
        /// <summary>
        /// run the test in the main method
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
            Console.WriteLine(CalculateBinaryTreeHeight(BST.root));
        }

        /// <summary>
        /// Calculate the height of the tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int CalculateBinaryTreeHeight(Node root)
        {
            if (root == null) return 0;
            int count = 0;
            if(root.Left == null && root.Right == null)
            {
                count++;
                return count;
            }
            // return count
            count++;
            // get the count on the left side
            int leftCount = count + CalculateBinaryTreeHeight(root.Left);
            //get a count on the right side
            int RightCount = count + CalculateBinaryTreeHeight(root.Right);
            return Math.Max(leftCount, RightCount);
        }
        
    }
}
