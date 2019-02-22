using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    public class Node
    {
        /// <summary>
        /// key in the array
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// value to be inserted
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Get the next node in list of the key
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Constructor that takes two parameters, one for the key and next for value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Node(string key, object value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
