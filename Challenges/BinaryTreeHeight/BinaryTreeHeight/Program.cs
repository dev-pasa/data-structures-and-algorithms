using System;
using Tree;
using Tree.Classes;

namespace BinaryTreeHeight
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
            Console.WriteLine(CalculateBinaryTreeHeight(BST.root));
        }

        public static int CalculateBinaryTreeHeight(Node root)
        {
            if (root == null) return 0;
            int count = 0;
            if(root.Left == null && root.Right == null)
            {
                count++;
                return count;
            }
            count++;
            int leftCount = count + CalculateBinaryTreeHeight(root.Left);
            int RightCount = count + CalculateBinaryTreeHeight(root.Right);
            return Math.Max(leftCount, RightCount);
        }
        
    }
}
