using System;
using Xunit;
using LinkedList;
using LLMerge;

namespace XUnitLLMergeTDD
{
    public class UnitTest1
    {
        [Fact]
        public void ListHead1()
        {
            MyLinkedList temp1 = new MyLinkedList(new Node(1));
            MyLinkedList temp2 = new MyLinkedList(new Node(2));

            //Assert
            
            Assert.Equal(temp1.Head.Value, LLMerge.Program.Merge(temp1, temp2).Head.Value);
        }

        [Fact]
        public void ListHead2()
        {
            MyLinkedList temp1 = new MyLinkedList(new Node(5));
            MyLinkedList temp2 = new MyLinkedList(new Node(6));
          
            //Assert

            Assert.Equal(temp1.Head.Value, LLMerge.Program.Merge(temp1, temp2).Head.Value);
        }

        [Fact]
        public void ListHead3()
        {
            MyLinkedList temp1 = new MyLinkedList(new Node(7));
            Node node2 = new Node(5);
            temp1.Append(node2.Value);
            MyLinkedList temp2 = new MyLinkedList(new Node(8));

            //Assert

            Assert.Equal(temp1.Head.Value, LLMerge.Program.Merge(temp1, temp2).Head.Value);
        }
    }
}
