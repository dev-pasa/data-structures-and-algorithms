using System;
using Xunit;
using Tree.Classes;
using FindMaxValue;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void BinaryTreeMAxValue1()
        {
            BinaryTree BT = new BinaryTree(5);
            BT.root.Left = new Node(11);
            BT.root.Left.Left = new Node(10);
            BT.root.Left.Right = new Node(15);
            BT.root.Right = new Node(12);
            BT.root.Right.Right = new Node(9);
            BT.root.Right.Left = new Node(17);

            Assert.Equal(17, Program.FindMax(BT.root));
            
        }

        [Fact]
        public void BinaryTreeMAxValue2()
        {
            BinaryTree BT = new BinaryTree(5);
            BT.root.Left = new Node(11);
            BT.root.Left.Left = new Node(10);
            BT.root.Left.Right = new Node(15);
            BT.root.Right = new Node(22);
            BT.root.Right.Right = new Node(19);
            BT.root.Right.Left = new Node(17);

            Assert.Equal(22, Program.FindMax(BT.root));

        }

        [Fact]
        public void BinaryTreeMAxValue3()
        {
            BinaryTree BT = new BinaryTree(25);
            BT.root.Left = new Node(11);
            BT.root.Left.Left = new Node(20);
            BT.root.Left.Right = new Node(15);
            BT.root.Right = new Node(12);
            BT.root.Right.Right = new Node(9);
            BT.root.Right.Left = new Node(27);

            Assert.Equal(27, Program.FindMax(BT.root));

        }
    }
}
