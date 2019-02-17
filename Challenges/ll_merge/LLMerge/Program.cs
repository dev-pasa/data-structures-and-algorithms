using System;
using LinkedList;


 namespace LLMerge
{
   public class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList first = new MyLinkedList(new Node(1));
            Node node3 = new Node(3);
            first.Append(3);
            first.Append(5);
            //first.Print();

            MyLinkedList second = new MyLinkedList(new Node(2));
            second.Append(8);
            second.Append(6);
            //second.Print();

            MyLinkedList newHead = Merge(first, second);
            //Console.WriteLine();
            newHead.Print();
            
        }


        public static MyLinkedList Merge(MyLinkedList list1, MyLinkedList list2)
        {
            Node current1 = list1.Head;
            Node current2 = list2.Head;

            MyLinkedList returnList = new MyLinkedList(new Node(current1.Value));

            current1 = current1.Next;
            Node returnNode = returnList.Head;

            while(current1 != null || current2 != null)
            {
                if( current2 != null)
                {
                    returnNode.Next = new Node(current2.Value);
                    current2 = current2.Next;
                    returnNode = returnNode.Next;
                }

                if (current1 != null)
                {
                    returnNode.Next = new Node(current1.Value);
                    current1 = current1.Next;
                    returnNode = returnNode.Next;
                }
            }
            return returnList;        
        }
    }
}
