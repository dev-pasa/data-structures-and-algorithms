using System;
using Xunit;
using Tree.Classes;
using HasSumPath;

namespace XUnitTestHasSumPAth
{
    public class UnitTest1
    {
        /// <summary>
        /// Test one to check whether the method runs correctly
        /// The sum should equal 3
        /// </summary>
        [Fact]
        public void TestHasSumPath1()
        {
            BinaryTree tree2 = new BinaryTree();
            tree2.root = new Tree.Classes.Node(1);
            tree2.root.Left = new Node(2);
            tree2.root.Right = new Node(4);
            int sum = 3;
            Assert.True(Program.hasSumPath(tree2.root, sum));
        }

        /// <summary>
        /// Test one to check whether the method runs correctly
        /// The sum should not equal 7
        /// </summary>
        [Fact]
        public void TestHasSumPath2()
        {
            BinaryTree tree2 = new BinaryTree();
            tree2.root = new Tree.Classes.Node(1);
            tree2.root.Left = new Node(2);
            tree2.root.Right = new Node(4);
            int sum = 7;
            Assert.False(Program.hasSumPath(tree2.root, sum));
        }

        /// <summary>
        /// Test one to check whether the method runs correctly
        /// The sum should equal 7
        /// </summary>
        [Fact]
        public void TestHasSumPath3()
        {
            BinaryTree tree2 = new BinaryTree();
            tree2.root = new Tree.Classes.Node(2);
            tree2.root.Left = new Node(5);
            tree2.root.Right = new Node(4);
            int sum = 7;
            Assert.True(Program.hasSumPath(tree2.root, sum));
        }
    }
}
