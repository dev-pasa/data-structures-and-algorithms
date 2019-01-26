using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Node
    {
        /// <summary>
        /// value property
        /// </summary>
        public int Value { get; set; }

        //node left and right
        public Node Left { get; set; }
        public Node Right { get; set; }

        /// <summary>
        /// Initialize the value of the root
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}
