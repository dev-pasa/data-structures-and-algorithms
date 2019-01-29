using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class Node
    {
        /// <summary>
        /// value property
        /// </summary>
        public object Value { get; set; }

        //node left and right
        public Node Left { get; set; }
        public Node Right { get; set; }

        /// <summary>
        /// Initialize the value of the root
        /// </summary>
        /// <param name="value"></param>
        public Node(object value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}
