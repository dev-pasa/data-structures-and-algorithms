using System;
using Xunit;
using System.Collections.Generic;
using Tree.Classes;

namespace XUnitTestForTree
{
    public class UnitTest1
    {
        /// <summary>
        /// Add a value to BST
        /// </summary>
        [Fact]
        public void AddBST1()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.root = bst.Add(bst.root, 1);
            Assert.Equal(1, bst.root.Value);
        }
        /// <summary>
        /// Add two value to BST
        /// </summary>
        [Fact]
        public void AddBST2()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.root = bst.Add(bst.root, 1);
            bst.root = bst.Add(bst.root, 2);
            Assert.True(bst.root.Value == 1 && bst.root.Right.Value == 2);
        }
        /// <summary>
        /// Add two value to BST
        /// </summary>
        [Fact]
        public void AddBST3()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.root = bst.Add(bst.root, 3);
            bst.root = bst.Add(bst.root, 2);
            bst.root = bst.Add(bst.root, 4);
            Assert.True(bst.root.Value == 3 && bst.root.Right.Value == 4 && bst.root.Left.Value == 2);
        }

        //Test BST Search value == root
        [Fact]
        public void BSTSearchValueIsRoot()
        {
            int[] value = { 6 };
            BinarySearchTree bst = new BinarySearchTree();
            bst.root = bst.Add(bst.root, 6);

            Assert.Equal(6, bst.Contains(bst.root, 6).Value);
        }

        //Test BST Search value == root
        [Fact]
        public void BSTSearchValueIsRoot2()
        {
            int[] value = { 5 };
            BinarySearchTree bst = new BinarySearchTree();
            bst.root = bst.Add(bst.root, 5);

            Assert.Equal(5, bst.Contains(bst.root, 5).Value);
        }

        //Test BST Search value == root
        [Fact]
        public void BSTSearchValueIsRoot3()
        {
            int[] value = { 1 };
            BinarySearchTree bst = new BinarySearchTree();
            bst.root = bst.Add(bst.root, 1);

            Assert.Equal(1, bst.Contains(bst.root, 1).Value);
        }

        /// <summary>
        /// Test three differnt values for PreOrder
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(7, 8, 9)]
        public void TestPreorder(int v1, int v2, int v3)
        {
            List<int> values = new List<int>();
            List<int> expected = new List<int> { v1, v2, v3 };
            BinaryTree bst = new BinaryTree(v1);
            bst.root.Left = new Node(v2);
            bst.root.Right = new Node(v3);
            bst.PreOrder(bst.root, values);
            Assert.Equal(expected, values);
        }

        /// <summary>
        /// Test three differnt values for InOrder
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(7, 8, 9)]
        public void TestInOrder(int v1, int v2, int v3)
        {
            List<int> values = new List<int>();
            List<int> expected = new List<int> { v2, v1, v3 };
            BinaryTree bst = new BinaryTree(v1);
            bst.root.Left = new Node(v2);
            bst.root.Right = new Node(v3);
            bst.InOrder(bst.root, values);
            Assert.Equal(expected, values);
        }

        /// <summary>
        /// Test three differnt values for InOrder
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(7, 8, 9)]
        public void TestPostOrder(int v1, int v2, int v3)
        {
            List<int> values = new List<int>();
            List<int> expected = new List<int> { v2, v3, v1 };
            BinaryTree bst = new BinaryTree(v1);
            bst.root.Left = new Node(v2);
            bst.root.Right = new Node(v3);
            bst.PostOrder(bst.root, values);
            Assert.Equal(expected, values);
        }
    }
}
