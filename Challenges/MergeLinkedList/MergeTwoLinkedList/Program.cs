using System;
using System.Collections.Generic;
using LinkedList;

namespace MergeTwoLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public Node MergeTwoList(Node l1, Node l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            Node head = null;

            if(l1.Value < l2.Value)
            {
                head = l1;
                l1 = l1.Next;
            }
            else
            {
                head = l2;
                l2 = l2.Next;
            }

            Node last = head;

            while(l1 != null && l2 != null)
            {
                if(l1.Value <= l2.Value)
                {
                    last.Next = l1;
                    l1 = l1.Next;
                }

                if(l2.Value <= l1.Value)
                {
                    last.Next = l2;
                    l2 = l2.Next;
                }
                last = last.Next;
            }

            if (l1 == null) last.Next = l2;
            else last.Next = l1;

            return head;
        }
    }
}
