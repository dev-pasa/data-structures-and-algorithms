using System;
using Tree.Classes;

namespace BinaryTreePaths
{
    public class Program
    {
        /// <summary>
        /// run the method in the main method
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

            PrintPaths(tree.root);
        }

        /// <summary>
        /// Method that prints the paths in the tree
        /// </summary>
        /// <param name="root"></param>
        public static void PrintPaths(Node root)
        {
            // create an array with a max size of 1000
            int[] paths = new int[1000];
            PrintMethod(root, paths, 0);
        }

        /// <summary>
        /// Create a helper method that takes in length, array for paths and the actual tree root
        /// </summary>
        /// <param name="root"></param>
        /// <param name="paths"></param>
        /// <param name="len"></param>
        public static void PrintMethod(Node root, int[] paths, int len)
        {
            // if root is null do nothing
            if (root == null) return;
            //as the number of root value inreases, the value in the path increases 
            paths[len++] = root.Value;
            //len++;

            // if there are no more nodes in the left or right and is the bottom of the tree print the values
            if (root.Left == null && root.Right == null)
            {
                PrintHelper(paths, len);
            }
            else
            {
                // recursive to the left side of the tree and the right side of the tree
                PrintMethod(root.Left, paths, len);
                PrintMethod(root.Right, paths, len);
            }
            
        }

        // print all the values in the array
        public static void PrintHelper(int[] paths, int len)
        {
            int i = len;
            for(i = 0; i < len; i++)
            {
                //print the first path
                Console.Write(paths[i] + " -> ");
            }
            // space between the paths
            Console.WriteLine( );
        }



    }
}
