using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MyLinkedList
    {

        //default empty value in head
        //insert value to the head
        // whether the value exists
        // print the all the values

        public class Node
        {
            public int Value;
            public Node Next;
            public Node(int value)
            {
                this.Value = value;
            }
            
        }
        public class LinkedList
        {
            public Node head;

            public void PrintAllheads()
            {
                Node current = head;
                while(current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                }
            }

            public void AddToHead(int value)
            {
                Node newNode = new Node(value);
                //question here
                newNode.Value = value;
                newNode.Next = head;
                head = newNode;
            }

            public static bool CheckValue(int Value)
                Node current = head;

            }
        }


    }
}