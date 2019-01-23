using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { set; get; }

        public Stack(int value)
        {
            Node node = new Node(value);
            Top = node;
        }

        public Stack()
        {

        }

        public void Push(int value)
        {
            Node node = new Node(value);
            node.next = Top;
            Top = node;
        }

        public Node Pop()
        {
            Node temp = Top;
            Top = Top.next;
            //Top.next = null;
            return temp;   
        }

        public Node Peek()
        {
            return Top;
        }
    }
}
