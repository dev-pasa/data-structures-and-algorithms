using System;
using Tree.Classes;

namespace FindMaxValue
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree BT = new BinaryTree(5);
            BT.root.Left = new Node(11);
            BT.root.Left.Left = new Node(10);
            BT.root.Left.Right = new Node(15);
            BT.root.Right = new Node(12);
            BT.root.Right.Right = new Node(9);
            BT.root.Right.Left = new Node(17);

            Console.WriteLine(FindMax(BT.root));
        }

        /// <summary>
        /// Method that takes in a node root and outputs the max value in the tree. 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int FindMax(Node root)
        {
            if (root == null) return int.MinValue;
            int max = root.Value;
            int leftVal = FindMax(root.Left);
            int rightVal = FindMax(root.Right);
            if (leftVal > max) max = leftVal;
            if (rightVal > max) max = rightVal;
            return max;
        }
    }
}
