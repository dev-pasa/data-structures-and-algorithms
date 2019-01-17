using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
      public class Node
    {
        /// <summary>
        /// create a value property that can later be assigned
        /// </summary>
        public int Value;
        public Node Next;
        
		public Node() { }
        /// <summary>
        /// create a node method
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
         Value = value;
         Next = null;
        }

    }
}

