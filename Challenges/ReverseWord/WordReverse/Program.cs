using System;

namespace WordReverse
{
    public class Program
    {
        /// <summary>
        /// Run the test on the main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("The original word is: Hellow World");
            Console.WriteLine("After reversing the input: ");
            Console.WriteLine(ReverseCharsInWord("Hello World"));
        }

        /// <summary>
        /// Create a method that reverses the chars in a word
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static String ReverseCharsInWord(String input)
        {
            // create a char array that has all the characters from the input
            char[] charsInWord = input.ToCharArray();

            // do a for loop from the front and the back at each index of the array
            for (int i = 0, j = charsInWord.Length - 1; i < j; i++, j--)
            {
                //reverse the chars in the character array
                char temp = charsInWord[i];
                charsInWord[i] = charsInWord[j];
                charsInWord[j] = temp;
            }
            //return a new string that has the reversed values in the character array
            return new String(charsInWord);
        }
    }
}
