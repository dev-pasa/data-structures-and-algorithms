using System;
using LinkedList;
using System.Collections.Generic;


namespace RemoveDuplicates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create nodes
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node duplicate = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            //create a linked list
            MyLinkedList list = new MyLinkedList(null);

            // add the nodes to the linked list
            list.Insert(node4);      
            list.Insert(node3);
            //Add duplicate with the same value
            list.Insert(duplicate);
            list.Insert(node2);
            list.Insert(node1);

            RemovdeDuplicates(list.Head);
            //PrintValuesLinkedList(list.Head);
            var Result = LinkedListToList(list.Head);

            Console.WriteLine("Linked list has values 1,2,2,3,4. After passing the linked list through the method. The result is:");
            foreach(int a in Result)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// create a method that removes duplicates from a linkedlist
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static void RemovdeDuplicates(Node head)
        {
            // create a reference to the head
            Node current = head;
            //traverse through the linked list
            while(current.Next != null)
            {
                // if current.next value is same as current value move to the next_next
                if ( current.Value == current.Next.Value)
                {
                    // value of next is value of next to next node
                    current.Next = current.Next.Next;
                }
                else
                {
                    // else keep traversing
                    current = current.Next;
                }                                   
            }            
        }

        /// <summary>
        /// Print the values of the linked list
        /// </summary>
        /// <param name="head"></param>
        public static void PrintValuesLinkedList(Node head)
        {
            //assign the current to the head
            Node current = head;
            while(current != null)
            {
                // print all the values of the linked list
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        /// <summary>
        /// Push the values of linkedlist to a list
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static List<int> LinkedListToList(Node head)
        {
            //create a list named result
            List<int> result = new List<int>();
            Node current = head;
            while (current != null)
            {
                // add the values to the list
                result.Add(current.Value);
                current = current.Next;
            }
            // return the lsit
            return result;          
        }

    }
}
