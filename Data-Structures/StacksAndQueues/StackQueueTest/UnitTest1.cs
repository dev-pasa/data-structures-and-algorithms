using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StackQueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void StackAdd()
        {
            Node node1 = new Node(1);
            Stack stack = new Stack(node1);

            Assert.Equal(1, stack.Top.Value);
        }
        [Fact]
        public void StackAdd2()
        {
            Node node1 = new Node(5);
            Stack stack = new Stack(node1);

            Assert.Equal(5, stack.Top.Value);
        }
        [Fact]
        public void StackAdd3()
        {
            Node node1 = new Node(7);
            Stack stack = new Stack(node1);

            Assert.Equal(7, stack.Top.Value);
        }
        [Fact]
        public void StackPush1()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Stack stack = new Stack(node1);
            stack.Push(2);

            Assert.Equal(2, stack.Top.Value);
        }
        [Fact]
        public void StackPush2()
        {
            Node node1 = new Node(1);
            Stack stack = new Stack(node1);
            stack.Push(3);

            Assert.Equal(3, stack.Top.Value);
        }
        [Fact]
        public void StackPush3()
        {
            Node node1 = new Node(1);
            Stack stack = new Stack(node1);
            stack.Push(5);

            Assert.Equal(5, stack.Top.Value);
        }

        [Fact]
        public void StackPop1()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Stack stack = new Stack(node1);
            stack.Push(2);
            stack.Push(5);
            stack.Pop();

            Assert.Equal(2, stack.Top.Value);
        }
        [Fact]
        public void StackPop2()
        {
            Node node1 = new Node(1);
            Stack stack = new Stack(node1);
            stack.Push(3);
            stack.Push(10);
            stack.Pop();

            Assert.Equal(3, stack.Top.Value);
        }
        [Fact]
        public void StackPop3()
        {
            Node node1 = new Node(1);
            Stack stack = new Stack(node1);
            stack.Push(5);
            stack.Push(12);
            stack.Pop();

            Assert.Equal(5, stack.Top.Value);
        }

        [Fact]
        public void StackPeek1()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Stack stack = new Stack(node1);
            stack.Push(2);
            stack.Push(5);
            
            Assert.Equal(5, stack.Peek().Value);
        }
        [Fact]
        public void StackPeek2()
        {
            Node node1 = new Node(1);
            Stack stack = new Stack(node1);
            stack.Push(3);
            stack.Push(10);
            
            Assert.Equal(10, stack.Peek().Value);
        }
        [Fact]
        public void StackPeek3()
        {
            Node node1 = new Node(1);
            Stack stack = new Stack(node1);
            stack.Push(5);
            stack.Push(12);
            
            Assert.Equal(12, stack.Peek().Value);
        }

        [Fact]
        public void NodePeek1()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Queue queue = new Queue(node1);
            queue.Enqueue(2);
            queue.Enqueue(5);

            Assert.Equal(1, queue.Peek().Value);
        }
        [Fact]
        public void NodePeek2()
        {
            Node node1 = new Node(2);
            Queue queue = new Queue(node1);
            queue.Enqueue(3);
            queue.Enqueue(10);

            Assert.Equal(2, queue.Peek().Value);
        }
        [Fact]
        public void NodePeek3()
        {
            Node node1 = new Node(3);
            Queue queue = new Queue(node1);
            queue.Enqueue(5);
            queue.Enqueue(12);

            Assert.Equal(3, queue.Peek().Value);
        }

        [Fact]
        public void NodeQueue1()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Queue queue = new Queue(node1);
            queue.Enqueue(2);
            queue.Enqueue(5);

            Assert.Equal(1, queue.Front.Value);
        }
        [Fact]
        public void NodeQueue2()
        {
            Node node1 = new Node(2);
            Queue queue = new Queue(node1);
            queue.Enqueue(3);
            queue.Enqueue(10);

            Assert.Equal(2, queue.Front.Value);
        }
        [Fact]
        public void NodeQueue3()
        {
            Node node1 = new Node(3);
            Queue queue = new Queue(node1);
            queue.Enqueue(5);
            queue.Enqueue(12);

            Assert.Equal(3, queue.Front.Value);
        }

        [Fact]
        public void NodeDequeue1()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Queue queue = new Queue(node1);
            queue.Enqueue(2);
            queue.Enqueue(5);
            queue.Dequeue();

            Assert.Equal(5, queue.Rear.Value);
        }
        [Fact]
        public void Noddequeue2()
        {
            Node node1 = new Node(2);
            Queue queue = new Queue(node1);
            queue.Enqueue(3);
            queue.Enqueue(10);
            queue.Dequeue();

            Assert.Equal(3, queue.Front.Value);
        }
        [Fact]
        public void Noddequeue3()
        {
            Node node1 = new Node(3);
            Queue queue = new Queue(node1);
            queue.Enqueue(5);
            queue.Enqueue(12);
            queue.Dequeue();

            Assert.Equal(5, queue.Peek().Value);
        }
    }
}
