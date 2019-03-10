using System;
using Xunit;
using BreadthFirst;
using Tree.Classes;

namespace XUnitTestBreadthFirst
{
    public class UnitTest1
    {
        /// <summary>
        /// Test if the method runs on a Binary Tree
        /// </summary>
        [Fact]
        public void BreadthTestBT1()
        {
            BinaryTree tree = new BinaryTree(1);
            tree.root.Left = new Node(2);
            tree.root.Right = new Node(3);
            tree.root.Left.Left = new Node(4);
            tree.root.Left.Right = new Node(5);
            tree.root.Right.Left = new Node(6);

            Program.BreadthFirstTraversal(tree);
        }

        /// <summary>
        /// Test if the method runs on a Binary Search Tree
        /// </summary>
        [Fact]
        public void BreadthBSTTest2()
        {
            BinarySearchTree BST = new BinarySearchTree();
            BST.Add(BST.root, 1);
            BST.Add(BST.root, 13);
            BST.Add(BST.root, 15);
            BST.Add(BST.root, 28);
            BST.Add(BST.root, 22);
            BST.Add(BST.root, 29);

            Program.BreadthFirstTraversal(BST);
        }

        /// <summary>
        /// Test if the method runs on a Binary Search Tree
        /// </summary>
        [Fact]
        public void BreadthBSTTest3()
        {
            BinarySearchTree BST = new BinarySearchTree();
            BST.Add(BST.root, 22);
            BST.Add(BST.root, 43);
            BST.Add(BST.root, 45);
            BST.Add(BST.root, 18);
            BST.Add(BST.root, 22);
            BST.Add(BST.root, 9);

            Program.BreadthFirstTraversal(BST);
        }
    }
}
