using System;
using LinkedList;

namespace KthNodeFromEnd
{
    public class Program
    {
        /// <summary>
        /// The main function to run the code
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Node node1 = new Node(1);

            MyLinkedList list = new MyLinkedList(node1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            list.Print();
            Console.WriteLine("1st node from end");
            Console.WriteLine(KthNodeEnd(list, 1));

            Console.WriteLine("2nd node from end");
            Console.WriteLine(KthNodeEnd(list, 2));
        }

        /// <summary>
        /// Find the Kth node from the end
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns>int value of Node</returns>
       // public static int KthNodeEnd(MyLinkedList list, int k)
       // {
       //     if (list.Head == null)
       //     {
       //         throw new NullReferenceException("List is null");
       //     }
       //     
       //     int count = 0;
       //     Node current = list.Head;
       //
       //     while (current.Next != null)
       //     {
       //         count++;
       //         current = current.Next;
       //     }
       //
       //     if (count < k)
       //     {
       //         throw new IndexOutOfRangeException("Index out of range.");
       //     }
       //
       //     current = list.Head;
       //
       //     while (count > k)
       //     {
       //         current = current.Next;
       //         count--;
       //     }
       //     return current.Value;
       // }

        public static int KthNodeEnd(MyLinkedList list, int k)
        {
            if (list.Head == null)
            {
                throw new NullReferenceException("List is null");
            }
            
            int count = 0;
            Node current = list.Head;
            
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            if (count < k)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
            
            current = list.Head;
            int n = count - k;
            int newCount = 0;

            while (current != null)
            {
                newCount++;
                if(newCount == n)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return current.Value;

        }
    }
}
