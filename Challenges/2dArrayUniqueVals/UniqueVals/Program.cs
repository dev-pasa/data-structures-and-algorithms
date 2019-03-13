using System;
using System.Collections.Generic;

namespace UniqueVals
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[,] input = new int[,] { { 1, 2, 3, 4, 5 }, { 4, 5, 6, 7, 8 }, { 6, 7, 8, 9, 10 } };
            //UniqueVals(input);

            Console.WriteLine("Print all the values in the given input");
            for(int i = 0; i < input.GetLength(0); i++)
            {
                for(int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write(input.GetValue(i,j) + " ");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Output after passing the method to remove duplicates");
            UniqueVals(input);

        }
        /// <summary>
        /// A method to remove collision using Hashset
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int> UniqueVals(int[,] input)
        {
            List<int> output = new List<int>();
            //create a hash set to remove collison among duplicates
            HashSet<int> set = new HashSet<int>();
            // add all the values in the hashset
            foreach (int ints in input)
            {
                set.Add(ints);
            }
            //Add all the values of hashset to list
            foreach (int val in set)
                output.Add(val);

            return output;
        }


       
    }
}