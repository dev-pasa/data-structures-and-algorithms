using System;
using LinkedList;


namespace RemoveDuplicates
{
    class Program
    {
        public static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            MyLinkedList list = new MyLinkedList(null);

            list.Insert(node4);
            
            list.Insert(node3);
            list.Insert(node2);
            list.Insert(node2);
            list.Insert(node1);
            //list.Print();
            //infinite loop

            RemovdeDuplicates(list.Head);
        }

        /// <summary>
        /// create a method that removes duplicates from a linkedlist
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static Node RemovdeDuplicates(Node head)
        {
            Node current = head;
            while(current != null && current.Next != null)
            {
                if(current.Next.Value == current.Value)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
                
            }
            return head;
        }
    }
}
