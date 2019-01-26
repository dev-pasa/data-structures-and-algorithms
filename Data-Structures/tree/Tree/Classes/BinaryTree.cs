using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        //create a root property
        public Node root { get; set; }

        //set the initial root value to null
        public BinaryTree()
        {
            root = null;
        }

        //initialize the value of root to given value
        public BinaryTree(int value)
        {
            root = new Node(value);
        }

        /// <summary>
        /// traverse the tree in preorder method
        /// </summary>
        /// <param name="root"></param>
        /// <param name="valuesInPreOrder"></param>
        public void PreOrder(Node root, List<int> valuesInPreOrder)
        {
            //if node is null
            if (root == null) return;
            //Else add values to list and call recursively on left and right nodes

            valuesInPreOrder.Add(root.Value);
            PreOrder(root.Left, valuesInPreOrder);
            PreOrder(root.Right, valuesInPreOrder);
        }


        /// <summary>
        /// traverse the tree in Inorder method
        /// </summary>
        /// <param name="root"></param>
        /// <param name="valuesInOrder"></param>
        public void InOrder(Node root, List<int> valuesInOrder)
        {
            //if node is null
            if (root == null) return;
            //Else add values to list and call recursively on left and right nodes
                        
            InOrder(root.Left, valuesInOrder);
            valuesInOrder.Add(root.Value);
            InOrder(root.Right, valuesInOrder);
        }

        /// <summary>
        /// traverse the tree in post order method
        /// </summary>
        /// <param name="root"></param>
        /// <param name="valuesInPostOrder"></param>
        public void PostOrder(Node root, List<int> valuesInPostOrder)
        {
            //if node is null
            if (root == null) return;
            //Else add values to list and call recursively on left and right nodes
            
            PostOrder(root.Left, valuesInPostOrder);
            PostOrder(root.Right, valuesInPostOrder);
            valuesInPostOrder.Add(root.Value);
        }
    }
}
