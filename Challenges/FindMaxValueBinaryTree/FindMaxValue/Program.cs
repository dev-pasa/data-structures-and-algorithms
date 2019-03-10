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
            //initial max is root value
            int max = root.Value;
            // recurside to left side
            int leftVal = FindMax(root.Left);
            // resursive to right side
            int rightVal = FindMax(root.Right);
            // check which side has max value
            if (leftVal > max) max = leftVal;
            if (rightVal > max) max = rightVal;
            // return max size
            return max;
        }

        /// <summary>
        /// Get the even values in the binary tree.
        /// IF the leaf value is odd, don't return it or add it to the output list
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static List<int> EvenLeafBinaryTree(Node root)
        {
            // create a list data structure
            List<int> output = new List<int>();
            //create a queue data structure
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            // while count of queue is greater than 0
            while(queue.Count > 0)
            {
                // deque the queue and assign the value to current
                Node current = queue.Dequeue();
                if(current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if(current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
                // check for leaf nodes and whether the mode value is even or mod == 0
                if(current.Left == null && current.Right == null && current.Value % 2 == 0)
                {
                    output.Add(current.Value);
                }
            }
            return output;
            
        }

        /// <summary>
        /// Breadth first traversal of the binary tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="list"></param>
        public static void BreadtFirstTraversal(Node root, List<int> list)
        {
            if (root == null) return;
            // create a queue data structure fro breadth first traversal
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            // while the count of queue is greater then 0 
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                // add the value to the given list
                list.Add(node.Value);
                //add the left side of the tree
                if (node.Left != null) queue.Enqueue(node.Left);
                // add the right side of the tree
                if (node.Right != null) queue.Enqueue(node.Right);
            }
        }

    }
}
