using System;
using System.Collections.Generic;
using System.Text;


namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(int value)
        {
            Node node = new Node(value);
            Front = node;
            Rear = node;
        }

        public void Enqueue(int value)
        {
            Node node = new Node(value);
            //Handle case where queue has been instantiated with null
            if (Rear == null && Front == null)
            {
                Front = node;
                Rear = Front;
            }
            else
            {
                Rear.next = node; 
                Rear = node; 
            }
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
