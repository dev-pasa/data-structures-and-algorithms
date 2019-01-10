using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(1);
            MyLinkedList list = new MyLinkedList(node);
            list.Insert(node);
            Console.WriteLine(list.head.Value);
        }
    }
}
