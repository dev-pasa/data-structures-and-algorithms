using System;
using System.Collections.Generic;
using System.Text;


namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        public void Enqueue(int value)
        {
            Node node = new Node(value);
            Rear.next = node;
            Rear = node;
        }

        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.next;
            temp.next = null;
            return temp;
        }

        public Node Peek()
        {
            return Front;
        }
    }
}
