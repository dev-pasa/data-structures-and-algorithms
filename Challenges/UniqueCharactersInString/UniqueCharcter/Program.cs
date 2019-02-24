using System;
using System.Collections.Generic;

namespace UniqueCharcter
{
    public class Program
    {
        //implementing the method
        public static void Main(string[] args)
        {
            string input = "Worldd!";
            Console.WriteLine(UniqueCharacters(input));
        }


        /// <summary>
        /// Create a method that checks if a string has unique characters
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool UniqueCharacters(string input)
        {
            //create a hasset called set
            HashSet<char> set = new HashSet<char>(input.Length);
            //put all the values in the set
            for (int i = 0; i < input.Length; i++)
            {
                if (!set.Add(input[i]))
                  return false;
            }
            return true;
        }
    }
}
