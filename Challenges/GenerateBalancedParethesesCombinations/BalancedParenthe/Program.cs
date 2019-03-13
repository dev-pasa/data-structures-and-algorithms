using System;

namespace BalancedParenthe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            char[] str = new char[2 * n];

            printParenthesis(str, n);
        }

        /// <summary>
        /// Cehck if the Parentheisis have equal values
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pos"></param>
        /// <param name="n"></param>
        /// <param name="open"></param>
        /// <param name="close"></param>
        public static void _printParenthesis(char[] str, int pos, int n, int open, int close)
        {
            if (close == n)
            {
                // print the possible combinations 
                for (int i = 0; i < str.Length; i++)
                    Console.Write("[" + str[i] + "]");

                Console.WriteLine();
                return;
            }
            else
            {
                if (open > close)
                {
                    str[pos] = '}';
                    _printParenthesis(str, pos + 1, n, open, close + 1);
                }
                if (open < n)
                {
                    str[pos] = '{';
                    _printParenthesis(str, pos + 1, n, open + 1, close);
                }
            }
        }

        /// <summary>
        /// check the parenthesis and if they match the count
        /// </summary>
        /// <param name="str"></param>
        /// <param name="n"></param>
        public static void printParenthesis(char[] str, int n)
        {
            if (n > 0)
                _printParenthesis(str, 0, n, 0, 0);
            return; 
        }
    }
}
