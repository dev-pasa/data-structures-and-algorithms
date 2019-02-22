using System;
using System.Collections.Generic;
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
            BT.root.Right.Right = new Node(20);
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

        public static List<int> EvenLeafBinaryTree(Node root)
        {
            List<int> output = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                Node current = queue.Dequeue();
                if(current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if(current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
                if(current.Left == null && current.Right == null & current.Value % 2 == 0)
                {
                    output.Add(current.Value);
                }
            }
            return output;
            
        }

        public static void BreadtFirstTraversal(Node root, List<int> list)
        {
            if (root == null) return;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                list.Add(node.Value);

                if (node.Left != null) queue.Enqueue(node.Left);

                if (node.Right != null) queue.Enqueue(node.Right);
            }
        }

    }
}
