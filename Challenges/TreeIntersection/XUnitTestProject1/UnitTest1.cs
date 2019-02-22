using System;
using Xunit;
using Hashtable.Classes;
using Hashtable;
using Tree.Classes;
using System.Collections.Generic;
using treeintersection;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// testing for common list
        /// </summary>
        [Fact]
        public void CommonNodeTrees1()
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.root = new Tree.Classes.Node(1);
            tree1.root.Left = new Tree.Classes.Node(2);
            tree1.root.Right = new Tree.Classes.Node(3);

            BinaryTree tree2 = new BinaryTree();
            tree2.root = new Tree.Classes.Node(1);
            tree2.root.Left = new Tree.Classes.Node(2);
            tree2.root.Right = new Tree.Classes.Node(4);

            List<int> result = new List<int>() { 1, 2 };

            Assert.Equal(result, Program.ListIntersectionBinaryTrees(tree1, tree2));
        }


        /// <summary>
        /// Testing for no values
        /// </summary>
        [Fact]
        public void CommonNodeTrees2()
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.root = new Tree.Classes.Node(1);
            tree1.root.Left = new Tree.Classes.Node(2);
            tree1.root.Right = new Tree.Classes.Node(3);

            BinaryTree tree2 = new BinaryTree();
            tree2.root = new Tree.Classes.Node(4);
            tree2.root.Left = new Tree.Classes.Node(5);
            tree2.root.Right = new Tree.Classes.Node(6);

            List<int> result = new List<int>() { 1, 2 };

            Assert.Empty(Program.ListIntersectionBinaryTrees(tree1, tree2));
        }

        /// <summary>
        /// testing for common list
        /// </summary>
        [Fact]
        public void CommonNodeTrees3()
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.root = new Tree.Classes.Node(1);
            tree1.root.Left = new Tree.Classes.Node(2);
            tree1.root.Right = new Tree.Classes.Node(3);

            BinaryTree tree2 = new BinaryTree();
            tree2.root = new Tree.Classes.Node(1);
            tree2.root.Left = new Tree.Classes.Node(2);
            tree2.root.Right = new Tree.Classes.Node(3);

            List<int> result = new List<int>() { 1, 2, 3 };

            Assert.Equal(result, Program.ListIntersectionBinaryTrees(tree1, tree2));
        }

    }
}
