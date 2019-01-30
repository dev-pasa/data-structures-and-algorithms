using System;
using Tree.Classes;
using System.Collections.Generic;

namespace BreadthFirst
{
   public class Program
    {
        /// <summary>
        /// Run the method in the main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(1);
            tree.root.Left = new Node(2);
            tree.root.Right = new Node(3);
            tree.root.Left.Left = new Node(4);
            tree.root.Left.Right = new Node(5);
            tree.root.Right.Left = new Node(6);
            Console.WriteLine("Breadth first traversal! ");
            BreadthFirstTraversal(tree);
        }

        /// <summary>
        /// Method to traverse through the data structure breadth first
        /// </summary>
        /// <param name="tree"></param>
        public static void BreadthFirstTraversal(BinaryTree tree)
        {
            Queue<Node> queue = new Queue<Node>();

            //if tree is Empty then return nothing
            if (tree.root == null) return;

            queue.Enqueue(tree.root);
            while (queue.Count > 0)
            {
                //create a node from queue peek value
                Node currentNode = queue.Peek();
                //print out the values
                Console.WriteLine(currentNode.Value);
                //check the left nodes
                if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                //check the right nodes
                if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
                queue.Dequeue();

            }
        }
    }
}
