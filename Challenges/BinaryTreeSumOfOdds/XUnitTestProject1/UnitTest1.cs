using System;
using Xunit;
using Tree.Classes;
using SumOfOdds;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestOddsInTree1()
        {
            BinaryTree BT = new BinaryTree(5);
            BT.root.Left = new Node(11);
            BT.root.Left.Left = new Node(10);
            BT.root.Left.Right = new Node(15);
            BT.root.Right = new Node(12);
            BT.root.Right.Right = new Node(9);
            BT.root.Right.Left = new Node(17);
           

            Assert.Equal(57, SumOfOdds.Program.SumofOdds(BT.root));
        }
    

   
    
        [Fact]
        public void TestOddsInTree2()
        {
            BinaryTree BT = new BinaryTree(5);
            BT.root.Left = new Node(11);
            BT.root.Left.Left = new Node(10);
            BT.root.Left.Right = new Node(15);
            BT.root.Right = new Node(12);
            BT.root.Right.Right = new Node(9);
            BT.root.Right.Left = new Node(17);


            Assert.Equal(57, SumOfOdds.Program.SumofOdds(BT.root));
        }
    

    
        [Fact]
        public void TestOddsInTree3()
        {
            BinaryTree BT = new BinaryTree(5);
            BT.root.Left = new Node(11);
            BT.root.Left.Left = new Node(10);
            BT.root.Left.Right = new Node(15);
            BT.root.Right = new Node(12);
            BT.root.Right.Right = new Node(9);
            BT.root.Right.Left = new Node(17);


            Assert.Equal(57, SumOfOdds.Program.SumofOdds(BT.root));
        }
    }
}
