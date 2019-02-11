using System;
using Xunit;
using IsBinaryTreeBalanced;
using Tree.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void BinaryTreeBlancedTest1()
        {
            BinaryTree tree = new BinaryTree(1);
            tree.root.Left = new Node(2);
            tree.root.Right = new Node(3);
            tree.root.Left.Left = new Node(4);
            tree.root.Left.Right = new Node(5);
            tree.root.Right.Left = new Node(6);

            Assert.True(Program.IsBinaryTreeBalanced(tree.root));

        }

        [Fact]
        public void BinaryTreeBlancedTest2()
        {
            BinaryTree tree = new BinaryTree(1);
            tree.root.Left = new Node(2);
            tree.root.Right = new Node(3);
            tree.root.Left.Left = new Node(4);
            tree.root.Left.Right = new Node(5);
            tree.root.Right.Left = new Node(6);
            tree.root.Left.Right.Right = new Node(12);
            tree.root.Left.Right.Right.Right = new Node(15);

            Assert.False(Program.IsBinaryTreeBalanced(tree.root));

        }

        [Fact]
        public void BinaryTreeBlancedTest3()
        {
            BinaryTree tree = new BinaryTree(1);
            tree.root.Left = new Node(2);
            tree.root.Right = new Node(3);
            tree.root.Left.Left = new Node(4);
            tree.root.Left.Right = new Node(9);
            tree.root.Right.Left = new Node(10);

            Assert.True(Program.IsBinaryTreeBalanced(tree.root));

        }
    }
}
