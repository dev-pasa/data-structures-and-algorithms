using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            // run the fibonacci test in console
            Console.WriteLine(Fibonacci(13));
        }

        public static int Fibonacci(int n)
        {    
            //inatilaize the variables as int.
            int fib = 1;
            int a = 0;
            int b = 1;

            //if the number is 0 return 0; if the number is 1 return 1 as fibonacci
            if (n <= 1) return n;

            for(int i = 2; i < n; i++)
            {
                
                a = b;
                b = fib;
                fib = a + b;
            }
            //return fib number
            return fib;
        }
    }
}
