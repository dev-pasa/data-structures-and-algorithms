using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree :BinaryTree
    {
        /// <summary>
        /// Add a new node in the Binary search tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
       public Node Add(Node root, int value)
        {
            if(root == null)
            {
                root = new Node(value);
                return root;
            }
            if (value < root.Value)
            {
                root.Left = Add(root.Left, value);
            }

            else if (value > root.Value)
            {
                root.Right = Add(root.Right, value);
            }
            return root;
        }

        /// <summary>
        /// Contains for the value in the tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Contains(Node root, int value)
        {
            if (root == null || root.Value == value) return root;

            if (value < root.Value) return Contains(root.Left, value);
            else return Contains(root.Right, value);
        }
    }
}
