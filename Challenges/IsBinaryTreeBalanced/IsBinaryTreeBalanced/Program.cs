using System;
using Tree.Classes;

namespace IsBinaryTreeBalanced
{
    public class Program
    {
        private static bool result = true;

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(1);
            tree.root.Left = new Node(2);
            tree.root.Right = new Node(3);
            tree.root.Left.Left = new Node(4);
            tree.root.Left.Right = new Node(5);
            tree.root.Right.Left = new Node(6);
            Console.WriteLine(IsBinaryTreeBalanced(tree.root));
        }

        /// <summary>
        /// return a boolean result 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsBinaryTreeBalanced(Node root)
        {
            HeightBinaryTree(root);
            // return true or false if the value is greater than 1
            return result;
        }

        /// <summary>
        /// find the height of the tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int HeightBinaryTree(Node root)
        {
            if (root == null) return 0;
            int count = 0;
            if (root.Left == null && root.Right == null)
            {
                count++;
                return count;
            }
            count++;
            //get the count of the right side and the left side
            int leftCount = count + HeightBinaryTree(root.Left);
            int rightCount = count + HeightBinaryTree(root.Right);
            // if the difference is greater then the one return false
            if (Math.Abs(leftCount - rightCount) > 1) result = false;
            // return the value 
            return Math.Max(leftCount, rightCount);
        }
    }
}