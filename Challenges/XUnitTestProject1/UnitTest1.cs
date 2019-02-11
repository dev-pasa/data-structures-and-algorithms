using System;
using Xunit;
using BinaryTreeHeight;
using Tree.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// test the height of the tree
        /// </summary>
        [Fact]
        public void TreeHeightTest1()
        {
            BinarySearchTree BST = new BinarySearchTree();
            BST.root = BST.Add(BST.root, 10);
            BST.root = BST.Add(BST.root, 15);
            BST.root = BST.Add(BST.root, 5);
            BST.root = BST.Add(BST.root, 8);
            BST.root = BST.Add(BST.root, 12);
            BST.root = BST.Add(BST.root, 19);

            Assert.Equal(3, BinaryTreeHeight.Program.CalculateBinaryTreeHeight(BST.root));
        }

        /// <summary>
        /// test the method to calculate the height of the tree
        /// </summary>
        [Fact]
        public void TreeHeightTest2()
        {
            BinarySearchTree BST = new BinarySearchTree();
            BST.root = BST.Add(BST.root, 10);
            BST.root = BST.Add(BST.root, 15);
            BST.root = BST.Add(BST.root, 5);
            BST.root = BST.Add(BST.root, 8);
            BST.root = BST.Add(BST.root, 12);
            BST.root = BST.Add(BST.root, 19);
            BST.root = BST.Add(BST.root, 20);
            BST.root = BST.Add(BST.root, 29);

            Assert.Equal(5, BinaryTreeHeight.Program.CalculateBinaryTreeHeight(BST.root));
        }

        /// <summary>
        /// test the method to calculate the height of the tree
        /// </summary>
        [Fact]
        public void TreeHeightTest3()
        {
            BinarySearchTree BST = new BinarySearchTree();
            BST.root = BST.Add(BST.root, 10);
            BST.root = BST.Add(BST.root, 15);
            BST.root = BST.Add(BST.root, 5);
            BST.root = BST.Add(BST.root, 8);
            BST.root = BST.Add(BST.root, 12);
            BST.root = BST.Add(BST.root, 19);
            BST.root = BST.Add(BST.root, 16);
            BST.root = BST.Add(BST.root, 49);

            Assert.Equal(4, BinaryTreeHeight.Program.CalculateBinaryTreeHeight(BST.root));
        }
    }
}
