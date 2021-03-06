using System;
using Xunit;
using PseudoQueue.Classes;


namespace XUnitPseudoQueueTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Test Dequeue
        /// </summary>    
        [Fact]
        public void TestDequeue1()
        {
            Queue q = new Queue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            int temp = q.Dequeue();
            Assert.Equal(1, temp);
        }
        /// <summary>
        /// Test Dequeue
        /// </summary>
        [Fact]
        public void TestDequeue2()
        {
            Queue q = new Queue(5);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            int temp = q.Dequeue();
            Assert.Equal(5, temp);
        }

        /// <summary>
        /// Test Dequeue
        /// </summary>
        [Fact]
        public void TestDequeue3()
        {
            Queue q = new Queue(6);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            int temp = q.Dequeue();
            Assert.Equal(6, temp);
        }

        /// <summary>
        /// Test Queue
        /// </summary>
        [Fact]
        public void Queue1()
        {
            Queue q = new Queue(1);
            int temp = q.Dequeue();
            Assert.Equal(1, temp);
        }

        /// <summary>
        /// Test Queue
        /// </summary>
        [Fact]
        public void Queue2()
        {
            Queue q = new Queue(2);
            int temp = q.Dequeue();
            Assert.Equal(2, temp);
        }

        /// <summary>
        /// Test Queue
        /// </summary>
        [Fact]
        public void Queue3()
        {
            Queue q = new Queue(3);
            int temp = q.Dequeue();
            Assert.Equal(3, temp);
        }

        /// <summary>
        /// Test DeQueue
        /// </summary>
        [Fact]
        public void DeQueue1()
        {
            Queue q = new Queue(1);
            int temp = q.Dequeue();
            Assert.Equal(1, temp);
        }
        [Fact]

        /// <summary>
        /// Test DeQueue
        /// </summary>
        public void DeQueue2()
        {
            Queue q = new Queue(5);
            int temp = q.Dequeue();
            Assert.Equal(5, temp);
        }

        /// <summary>
        /// Test DeQueue
        /// </summary>
        [Fact]
        public void DeQueue3()
        {
            Queue q = new Queue(6);
            int temp = q.Dequeue();
            Assert.Equal(6, temp);
        }
    }
}
