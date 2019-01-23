using System;
using StacksAndQueues.Classes;

namespace PseudoQueue
{
    class Program
    {

        static void Main(string[] args)
        {
            QueueWithStacks();
        }

        public static void QueueWithStacks()
        {
            Queue q = new Queue(1);
            q.Enqueue(2);
            int temp1 = q.Peek().Value;

            Console.WriteLine($"The value of the node in the bottom of the stack is {temp1}");

            q.Enqueue(3);
            q.Enqueue(4);

            Node temp2 = q.Dequeue();
            Console.WriteLine($"The value of the node that is dequeued is {temp1}");

            int temp3 = q.Peek().Value;
            Console.WriteLine($"The value of the node in the new bottom of the stack is {temp3}");
        }

     }
}
