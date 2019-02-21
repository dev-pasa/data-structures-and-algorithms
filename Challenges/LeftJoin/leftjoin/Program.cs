using System;
using System.Collections;
using System.Collections.Generic;
using Hashtable.Classes;


namespace leftjoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable hasht1 = new HashTable(5);
            hasht1.Add("5", "hello");
            hasht1.Add("6", "world");
            hasht1.Add("7", "hello");
            hasht1.Add("8", "world");
            //hasht1.Add("2", "cat");

            HashTable hasht2 = new HashTable(5);
            hasht2.Add("5", "hell");
            hasht2.Add("6", "worl");
            //hasht1.Add("7", "hell");
            //hasht1.Add("8", "worl");

            List<string[]> leftjoin = LeftJoin(hasht1, hasht2);

            foreach (string[] vals in leftjoin)
            {
                Console.WriteLine(" [ " + vals[0] + " , " + vals[1] + " , "+ vals[2] + " ] ");
            }
        }

        /// <summary>
        /// Create a function called left join
        /// </summary>
        /// <param name="table1"></param>
        /// <param name="table2"></param>
        /// <returns></returns>
        public static List<string[]> LeftJoin(HashTable table1, HashTable table2)
        {
            //create an empty list
            List<string[]> list = new List<string[]>();

            //do a for loop therough the entire hash table
            for (int i = 0; i < table1.Storage.Length; i++)
            {             
                //create a node for tracker
               Node current = table1.Storage[i];

                // create an array with size 3
                string[] arraylist = new string[3]; 

                //while loop till the list is null
               while (current != null)
                {
                    //set the values of index at 0 and 1
                    arraylist[0] = current.Key;
                    arraylist[1] = current.Value.ToString();
                    
                    //check if the second table contains the value
                    if (table2.Contains(current.Key))
                    {
                        //result = result + table2.Storage[i].Value + "] ";
                        arraylist[2] = table2.Storage[i].Value.ToString();
                    }
                    else
                    {
                        //result = result + "NULL" + "] ";
                        arraylist[2] = "Null";
                    }
                    //add all the values to the list
                    list.Add(arraylist);
                    //keep iterating through the hash table
                    current = current.Next;
                }

            }
                //return the list
                return list;
            }

        }
    }

