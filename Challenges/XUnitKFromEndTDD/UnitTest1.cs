using System;
using Xunit;
using LinkedList;
using KthNodeFromEnd;


namespace XUnitKFromEndTDD
{
    public class UnitTest1
    {
        [Fact]
        public void KthFromEnd1()
        {
            //arrange
            Node node1 = new Node(1);
            MyLinkedList list = new MyLinkedList(node1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            //act

            //asserted
            Assert.Equal(4, KthNodeFromEnd.Program.KthNodeEnd(list, 1));
        }

        [Fact]
        public void KthFromEnd2()
        {
            //arrange
            Node node1 = new Node(1);
            MyLinkedList list = new MyLinkedList(node1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            //act

            //asserted
            Assert.Equal(3, KthNodeFromEnd.Program.KthNodeEnd(list, 2));
        }

        [Fact]
        public void KthFromEnd3()
        {
            //arrange
            Node node1 = new Node(1);
            MyLinkedList list = new MyLinkedList(node1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            //act

            //asserted
            Assert.Equal(2, KthNodeFromEnd.Program.KthNodeEnd(list, 3));
        }
    }
}
