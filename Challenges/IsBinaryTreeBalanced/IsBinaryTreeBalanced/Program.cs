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

        public static bool IsBinaryTreeBalanced(Node root)
        {
            HeightBinaryTree(root);
            return result;
        }


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
            int leftCount = count + HeightBinaryTree(root.Left);
            int rightCount = count + HeightBinaryTree(root.Right);
            if (Math.Abs(leftCount - rightCount) > 1)
                result = false;
            return Math.Max(leftCount, rightCount);
        }
    }
}