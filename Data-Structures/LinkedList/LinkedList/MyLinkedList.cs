using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MyLinkedList
    {
        public MyLinkedList(Node node)
        {

        }

        //default empty value in head
        //insert value to the head
        // whether the value exists
        // print the all the values

            public Node head = null;

            public void Print()
            {
                Node current = head;
                while(current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                }
            }

            public void Insert(Node node)
            {
                //Node newNode = new Node();
                //question here
               // newNode.Value = value;
                node.Next = head;
                head = node;
            }

            public bool Includes(int value)
            {
                Node current = head;
                if ( current == null)
                {
                    return false;
                }
                while (head.Next != null)
                {
                    if (current.Value == value)
                    {
                        return true;
                    }
                    return false;
                }

                return false;

            }
        }


    }
