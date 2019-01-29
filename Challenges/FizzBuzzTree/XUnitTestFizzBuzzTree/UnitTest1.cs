using System;
using Xunit;
using static FizzBuzzTree.Program;
using FizzBuzzTree.Classes;
namespace XUnitTestFizzBuzzTree
{
    public class UnitTest1
    {
        [Fact]
        public void FizzBuzzTest1()
        {
            BinaryTree BT = new BinaryTree(5);
            BT.root.Left = new Node(11);
            BT.root.Left.Left = new Node(10);
            BT.root.Left.Right = new Node(15);
            BT.root.Right = new Node(12);
            BT.root.Right.Right = new Node(9);
            BT.root.Right.Left = new Node(17);

            FizzBuzzTree.Program.FizzBuzzTree(BT);
        }

        [Fact]
        public void FizBuzzTest2()
        {
            BinarySearchTree BST = new BinarySearchTree();
            BST.root = BST.Add(BST.root, 10);
            BST.root = BST.Add(BST.root, 15);
            BST.root = BST.Add(BST.root, 5);
            BST.root = BST.Add(BST.root, 8);
            BST.root = BST.Add(BST.root, 12);
            BST.root = BST.Add(BST.root, 19);

            FizzBuzzTree.Program.FizzBuzzTree(BST);
        }

        [Fact]
        public void FizBuzzTest3()
        {
            BinarySearchTree BST = new BinarySearchTree();
            BST.root = BST.Add(BST.root, 12);
            BST.root = BST.Add(BST.root, 13);
            BST.root = BST.Add(BST.root, 5);
            BST.root = BST.Add(BST.root, 18);
            BST.root = BST.Add(BST.root, 22);
            BST.root = BST.Add(BST.root, 29);

            FizzBuzzTree.Program.FizzBuzzTree(BST);
        }
    }
}
