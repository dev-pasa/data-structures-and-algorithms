using System;
using Hashtable.Classes;
using Hashtable;
using Tree.Classes;
using System.Collections.Generic;

namespace treeintersection
{
   public  class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.root = new Tree.Classes.Node(1);
            tree1.root.Left = new Tree.Classes.Node(2);
            tree1.root.Right = new Tree.Classes.Node(3);

            BinaryTree tree2 = new BinaryTree();
            tree2.root = new Tree.Classes.Node(1);
            tree2.root.Left = new Tree.Classes.Node(2);
            tree2.root.Right = new Tree.Classes.Node(4);
            foreach (var item in ListIntersectionBinaryTrees(tree1, tree2))
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Output using a list
        /// </summary>
        /// <param name="tree1"></param>
        /// <param name="tree2"></param>
        /// <returns></returns>
        public static List<int> ListIntersectionBinaryTrees(BinaryTree tree1, BinaryTree tree2)
        {
            
            Tree.Classes.Node curentNode = tree1.root;       
            //create a list
            List<int> preOrderVals1 = new List<int>();
            //create a hashtable
            HashTable treeHashTable = new HashTable(50);
            //preorder traversal
            tree1.PreOrder(tree1.root, preOrderVals1);
            //traverse through the list
            foreach (int num in preOrderVals1)
            {
                treeHashTable.Add(num.ToString(), true);
            }
            //create another list

            List<int> preOrderVals2 = new List<int>();

            tree2.PreOrder(tree2.root, preOrderVals2);
            //create a list that holds common values
            List<int> commonValues = new List<int>();
            //push the values of second list to hash table
            //check for common words
            foreach (int num in preOrderVals2)
            {
                if (treeHashTable.Contains(num.ToString()))
                {
                    commonValues.Add(num);
                }
               else
                {
                    //add the common values to a new list
                    treeHashTable.Add(num.ToString(), true);
                }

            }

            return commonValues;
        }

        /// <summary>
        /// Find common node values using a stack
        /// </summary>
        /// <param name="rootA"></param>
        /// <param name="rootB"></param>
        /// <returns></returns>
        public static List<int> Intersection(Tree.Classes.Node rootA, Tree.Classes.Node rootB)
        {
            List<int> list = new List<int>();

            Stack<Tree.Classes.Node> stack1 = new Stack<Tree.Classes.Node>();
            Stack<Tree.Classes.Node> stack2 = new Stack<Tree.Classes.Node>();

            while (true)
            {
                if (rootA != null)
                {
                    stack1.Push(rootA);
                    rootA = rootA.Left;
                }
                if (rootB != null)
                {
                    stack2.Push(rootB);
                    rootB = rootB.Right;
                }

                else if (stack1.Count == 0 && stack2.Count == 0)
                {
                    rootA = stack1.Peek();
                    rootB = stack2.Peek();

                    if (rootA.Value == rootB.Value)
                    {
                        list.Add(rootA.Value);
                        stack1.Pop();
                        stack2.Pop();

                        rootA = rootA.Right;
                        rootB = rootB.Right;
                    }

                    else if (rootA.Value < rootB.Value)
                    {
                        stack1.Pop();
                        rootA = rootA.Right;

                        rootB = null;
                    }

                    else if (rootA.Value > rootB.Value)
                    {
                        stack2.Pop();
                        rootB = rootB.Right;
                        rootA = null;
                    }
                }
                return list;
            }
        }
    }
}
