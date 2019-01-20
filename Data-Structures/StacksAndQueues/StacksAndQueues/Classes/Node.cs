using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
