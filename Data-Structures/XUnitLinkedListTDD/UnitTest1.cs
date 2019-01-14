using System;
using Xunit;
using LinkedList;

namespace XUnitLinkedListTDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestingIncludes1()
        {
            //arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            node1.Next = node2;
            node2.Next = node3;
            MyLinkedList list = new MyLinkedList(node1);
            //act

            //asserted
            //Assert.Equal(true, list.Includes(1));
            Assert.True(list.Includes(1));
        }

        [Fact]
        public void TestingIncludes2()
        {
            //arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
          
            MyLinkedList list = new MyLinkedList(node1);
            //act

            //asserted
            //Assert.Equal(true, list.Includes(1));
            Assert.False(list.Includes(2));
        }

        [Fact]
        public void TestingIncludes3()
        {
            //arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            node1.Next = node2;
            node2.Next = node3;
            MyLinkedList list = new MyLinkedList(node1);
            list.Insert(node2);
            list.Insert(node3);
            //act

            //asserted
            //Assert.Equal(true, list.Includes(1));
            Assert.True(list.Includes(2));
        }

        [Fact]
        public void InsertIncludes1()
        {
            //arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            node1.Next = node2;
            node2.Next = node3;
            MyLinkedList list = new MyLinkedList(node1);
            list.Insert(node2);
            list.Insert(node3);
            //act

            //asserted
            //Assert.Equal(true, list.Includes(1));
            Assert.Equal(3, list.Head.Value);
        }

        [Fact]
        public void InsertIncludes2()
        {
            //arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            node1.Next = node2;
            node2.Next = node3;
            MyLinkedList list = new MyLinkedList(node1);
            list.Insert(node2);
            list.Insert(node4);
            //act

            //asserted
            
            Assert.Equal(4, list.Head.Value);
        }

        [Fact]
        public void InsertIncludes3()
        {
            //arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node5 = new Node(5);
            node1.Next = node2;
            node2.Next = node3;
            MyLinkedList list = new MyLinkedList(node1);
            list.Insert(node2);
            list.Insert(node5);
            //act

            //asserted

            Assert.Equal(5, list.Head.Value);
        }

        [Fact]
        public void AppendTes1()
        {
            //arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            
            node1.Next = node2;
            node2.Next = node3;
            MyLinkedList list = new MyLinkedList(node1);
            list.Insert(node2);
            list.Append(5);
            //act

            //asserted

            Assert.Equal(5, list.Next.Next.Value);
        }
    }
}
