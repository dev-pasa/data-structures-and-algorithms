using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace PseudoQueue.Classes
{
   public class Queue
    {

        Stack stack1 = new Stack();
        Stack stack2 = new Stack();
        //Node newNode;

        //public Node Front { get; set; }
        //public Node Rear { get; set; }

        public Queue(int value)
        {
            Node newNode = new Node(value);
            stack1.Push(value);
            //Front = Rear = newNode;
        }

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            stack1.Push(value);
            //Rear = newNode;
        }

        public int Dequeue()
        {
            while(stack1.Peek() != null)
            {
                stack2.Push(stack1.Pop().Value);
            }

            Node temp = stack2.Pop();

            while (stack2.Peek() != null)
            {
                
                stack1.Push(stack2.Pop().Value);
            }
            return temp.Value;
        }



    }
}
