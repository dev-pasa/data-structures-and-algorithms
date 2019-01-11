using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
    public class MyLinkedList
    {

        public Node Head { get; set; } = null;

        public MyLinkedList(Node node)
        {
            Head = node;

        }

        //default empty value in head
        //insert value to the head
        // whether the value exists
        // print the all the values
        //public Node head = null;


        public void Print()
            {
                Node current = Head;
                while(current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;

                }
    
            }
           
            /// <summary>
            /// add node to the head
            /// </summary>
            /// <param name="node"></param>
            public void Insert(Node node)
            {
            //// if passed in an int
            // Node newNode = new Node(value);
            //question here
            //newNode.Value = value;
            // newNode.Next = Head;
            //Head = newNode;

             node.Next = Head;
             Head = node;
            }

            /// <summary>
            /// check if the value exists
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public bool Includes(int value)
            {
                Node current = Head;
                if ( current == null)
                {
                    return false;
                }
                while (current != null)
                {
                
                    if (current.Value == value)
                    {
                        return true;
                    }
                current = current.Next;
                }

               ////For me -- if I have curent.next
                //if(current.Value == value)
                //{
                    //return true;
                //}

                return false;

            }
        }


    }
