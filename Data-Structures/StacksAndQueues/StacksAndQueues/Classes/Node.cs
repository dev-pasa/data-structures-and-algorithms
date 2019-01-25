using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node
    {
        public object Value { get; set; }
        public Node next { get; set; }

        public Node(object value)
        {
            Value = value;
        }
    }
}
