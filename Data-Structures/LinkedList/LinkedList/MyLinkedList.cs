using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
    public class MyLinkedList
    {

        public Node Head { get; set; } = null;

        public Node Current { get; set; }

        public Node Next { get; set; }

        //public Node Previous { get; set; }

        public MyLinkedList(Node node)
        {
            Head = node;
            Current = node;
            //Previous = null;
            Next = null;
        }

        //default empty value in head
        //insert value to the head
        // whether the value exists
        // print the all the values
        //public Node head = nul
        
            /// <summary>
            /// Print all the values in the node
            /// </summary>
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

               ////For me note -- if I have curent.next
                //if(current.Value == value)
                //{
                    //return true;
                //}

                return false;

        }

        //append(value) which adds a new node with the given value to the end of the list
        /// <summary>
        /// Add an int value, convert it to node and add to the end
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            Node new_node = new Node(value);
            if (Head == null)
            {
                Head = new_node;
            }
            else
            {
                Node last = Head;
                while (last.Next != null)
                {
                    last = last.Next;   
                }
                last.Next = new_node;
            }
            
        }

        
      

        //insertAfter(value, newVal) which add a new node with the given newValue immediately after the first value node
        /// <summary>
        /// Indert the value before the given Node
        /// </summary>
        /// <param name="prev_node"></param>
        /// <param name="newVal"></param>
        public Node InsertBefore(Node given_node, int insertBeforeVal)
        {
            Node new_node = new Node(insertBeforeVal);

            if (given_node == null)
            {
                Console.WriteLine("pre_node cannot be null");
            }

            Current = Head;
            while(Current != null)
            {             
                if (Current.Next == given_node)
                {
                    new_node.Next = given_node;
                    Current.Next = new_node;
                    return Current;
                }
                Current = Current.Next;
            }
            return Current;
        }

        //insertBefore(value, newVal) which add a new node with the given newValue immediately before the first value node
        /// <summary>
        /// 
        /// </summary>
        /// <param name="given_node"></param>
        /// <param name="insertBeforeVal"></param>
        /// <returns></returns>
        public Node InsertAfter(Node given_node, int insertBeforeVal)
        {
            Node new_node = new Node(insertBeforeVal);

            if (given_node == null)
            {
                Console.WriteLine("pre_node cannot be null");
            }
            Current = Head;
            while (Current != null)
            {
                if (Current.Next == given_node)
                {
                    new_node.Next = given_node.Next;
                    given_node.Next = new_node;     
                    return Current;
                }
                Current = Current.Next;
            }
            return Current;
        }
    }

}


    
