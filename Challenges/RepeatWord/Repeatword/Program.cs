using System;
using Hashtable.Classes;

namespace Repeatword
{
   public class Program
    {
        static void Main(string[] args)
        {
            string input = "Once upon a time, there was a brave princess who...";
            Console.WriteLine("Repeat word from input: " + RepeatWord(input));


            string input2 = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            Console.WriteLine("Repeat word from input2: " + RepeatWord(input2));
        }

       public static string RepeatWord(string input)
        {
            string[] values = input.Split(" ");
            char[] nonWords = { '"', '.', '?', '!', ',' , '*', '#'};

            HashTable hashTable = new HashTable(150);

            for(int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim(nonWords).ToLower();
            }

            foreach(string val in values)
            {
                if (hashTable.Contains(val))
                {
                    return val;
                }
                else
                {
                    hashTable.Add(val, true);
                }
            }
                return "No Repeat Found";
        }
    }
}
