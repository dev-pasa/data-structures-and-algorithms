using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentChar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passed input: Hello World!, Expected output: character l");
            Console.WriteLine(SingleMostFreqChar("Hello World!"));
        }

        /// <summary>
        /// Print the most frequent character in String
        /// </summary>
        /// <param name="input"></param>
        public static char SingleMostFreqChar(String input)
        {
            Int32 count;
            Dictionary<Char, int> bucket = new Dictionary<char, int>();
            //store all the chars from passed input in an char array
            char[] charArray = input.ToCharArray();
            // loop through the entire charArray and input it in the dictionary, if the key already exists, increment the value
            foreach (var i in charArray)
            {
                // loop through the entire charArray and input it in the dictionary, if the key already exists, increment the value
                if (bucket.TryGetValue(i, out count))
                {
                    count++;
                    bucket[i] = count;
                }
                else
                {
                    count = 1;
                    bucket.Add(i, count);
                }
            }
            //get the max character
            var MaxKeyOnly = bucket.FirstOrDefault(x => x.Value == bucket.Values.Max()).Key;
            //return the character
            return MaxKeyOnly;

        }

        // similar method with multiple outputs to find both the key and value
        public static void FreqCharValues(String input)
        {
            Int32 count;

            Int32 maxCount = 0;

            Dictionary<Char, int> bucket = new Dictionary<char, int>();
            char[] charArray = input.ToCharArray();

            foreach (var i in charArray)
            {
                if (bucket.TryGetValue(i, out count))
                {
                    count++;
                    bucket[i] = count;
                }
                else
                {
                    count = 1;
                    bucket.Add(i, count);
                }
            }

            foreach (KeyValuePair<char, int> kvp in bucket)
            {
                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                Console.WriteLine(("Key = {0}, Value = {1}", kvp.Key, kvp.Value));
            }

            var maxKey = bucket.Keys.Max();
            var maxValue = bucket.Values.Max();
            var keyWithMaxValue = bucket.Aggregate((x, y) => x.Value > y.Value ? x : y);
            Console.WriteLine("Key with Max Value");
            Console.WriteLine(keyWithMaxValue);
        }
    }

}
