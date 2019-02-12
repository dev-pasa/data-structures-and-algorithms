using System;
using LinkedList;
namespace ShuffleList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            MyLinkedList list = new MyLinkedList(null);
            list.Head = new Node(5);
            list.Insert(node4);
            list.Insert(node3);
            list.Insert(node2);
            list.Insert(node1);
            list.Print();
            Console.WriteLine();
            ShuffleLinkedList(list.Head);
            list.Print();
        }

        /// <summary>
        /// method to rever the linked list
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static Node Reverselist(Node node)
        {
            Node prev = null, curr = node, next;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }

            node = prev;
            return node;
        }

        /// <summary>
        /// method to shuffle the list
        /// </summary>
        /// <param name="node"></param>
        public static void ShuffleLinkedList(Node node)
        {
            //create trackers for node root
            Node current = node;

            //create runners and split the nodes into two lists
            Node node1 = node;
            Node node2 = current.Next;
            current.Next = null;
            //reverse the second half nodes
            node2 = Reverselist(node2);
            //merge the nodes
            node = new Node(0);
            Node curr = node;
            //run a loop through the entire list and swap the order
            while (node1 != null || node2 != null)
            {
                //add the first list
                if (node1 != null)
                {
                    curr.Next = node1;
                    curr = curr.Next;
                    node1 = node1.Next;
                }
                //add the second list
               if (node2 != null)
                {
                    curr.Next = node2;
                    curr = curr.Next;
                    node2 = node2.Next;
                }
            }

            node = node.Next;
        }
    }
}
