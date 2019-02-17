using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    public class HashTable
    {
        /// <summary>
        /// Holds the data
        /// </summary>
        public Node[] Storage { get; set; }

        /// <summary>
        /// total size of the data
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Total Buckets
        /// </summary>
        public int Buckets { get; set; }

        /// <summary>
        /// A hash table is a collection of items which are stored in such a way as to make it easy to find them later. 
        /// </summary>
        /// <param name="capacity"></param>
        public HashTable(int capacity)
        {
            Buckets = capacity;
            Node[] temp = new Node[Buckets];
            Storage = temp;
            Size = 0;
        }

        /// <summary>
        /// Chain hashing avoids collision. 
        /// The idea is to make each cell of hash table point to a linked list of records that have same hash function value.
        /// One approach to collision resolution is to build linked list of the key-value pairs whose keys hash to that index
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Hashing(string key)
        {
            long hashValue = 0;

            for (int i = 0; i < key.Length; i++)
            {
                long charValue = (int)key[i];
                hashValue = hashValue + charValue;

            }
            hashValue = hashValue * 333;
            hashValue = hashValue % Buckets;

            int hashKey = Convert.ToInt32(hashValue);
            return hashKey;
        }

        /// <summary>
        /// Create an Add method to add values to table
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, object value)
        {
            Node current = new Node(key, value);
            int index = Hashing(key);

            if (Storage[index] == null)
            {
                Storage[index] = current;
            }
            else
            {
                Node currentNode = Storage[index];
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = current;
            }

            Size++;
        }

        /// <summary>
        /// Create a get method to check if the value exits
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object Get(string key)
        {
            int index = Hashing(key);
            //Traverse the bucket storage to find the key
            Node current = Storage[index];
            while (current != null)
            {
                if (current.Key == key)
                {
                    //Return the value
                    return current.Value;
                }
                current = current.Next;
            }
            //Else return null
            return null;
        }

        /// <summary>
        /// Check if the table contains the given key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            int index = Hashing(key);
            if (Storage[index] == null)
            {
                return false;
            }
            if (Storage[index].Key == key)
            {
                return true;
            }
            else
            {
                Node current = Storage[index];
                while (current != null)
                {
                    if (current.Key == key)
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }
        }

        /// <summary>
        /// Create a remove method in the hash table
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            if (!Contains(key))
            {
                Console.WriteLine($"Not Found {key}");
            }

            else
            {
                int index = Hashing(key);
                if ((Storage[index].Key == key && Storage[index].Next == null))
                {
                    Console.WriteLine($"Removing {Storage[index].Key} {Storage[index].Value} from hashtable.");
                    Storage[index] = null;
                    Size = Size - 1;
                }
                else
                {
                    Node currentNode = Storage[index];
                    while (currentNode.Next.Key != key && currentNode.Next != null)
                    {
                        if (currentNode.Next.Key == key && currentNode.Next.Next != null)
                        {
                            currentNode.Next = currentNode.Next.Next;
                            Size = Size - 1;
                        }
                        else
                        {
                            currentNode.Next = null;
                            Size = Size - 1;
                        }
                        currentNode = currentNode.Next;
                    }

                }
            }
        }

    }
}