using System;
using Hashtable.Classes;
using System.Collections.Generic;


namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create table and add key values
            HashTable hashTable = new HashTable(5);
            hashTable.Add("Seattle", "Snow");
            hashTable.Add("hello", "world");
            hashTable.Add("mamma", "mia");
            hashTable.Add("data", "structure");
            hashTable.Add("always", "trying");

            List<string> keys = new List<string>();
            keys.Add("Seattle");
            keys.Add("hello");
            keys.Add("mamma");
            keys.Add("data");
            keys.Add("always");

            //print the key and test if they are in the table
            foreach (string word in keys)
            {
                Console.WriteLine($"{word}: {hashTable.Contains(word)}");
            }
        }
    }
}
