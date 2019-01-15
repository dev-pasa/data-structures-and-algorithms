using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            //node1.Next = node2;
            //node2.Next = node3;

            MyLinkedList list = new MyLinkedList(null);
            
            list.Insert(node3);
            list.Insert(node2);
            list.Insert(node1);
            //list.Append(5);
            //list.InsertBefore(node2, 7);
            list.InsertAfter(node3, 7);
   
            list.Print();
            
        }
    }
}
