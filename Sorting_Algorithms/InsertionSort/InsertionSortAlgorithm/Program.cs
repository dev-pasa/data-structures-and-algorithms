using System;


namespace InsertionSortAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 2, 3, 4, 5, 1 };
            PreSortArray(array1);
            InsertionSort(array1);
            PrintArray(array1);

            Console.WriteLine();
            int[] array2 = { 12, 13, 14, 15, 11 };
            PreSortArray(array2);
            InsertionSort(array2);
            PrintArray(array2);

            Console.WriteLine();
            int[] array3 = { 22, 23, 24, 25, 21 };
            PreSortArray(array3);
            InsertionSort(array3);
            PrintArray(array3);
            Console.WriteLine();
        }

        /// <summary>
        /// a method that takes in an array and sorts them starting at array[0] and returns the full array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] InsertionSort(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                int j = 0;

                //set the value of j
                if (i > 0)
                {
                    j = i - 1;
                };
                //set the values
                int target = array[i];
                int previous = array[j];

                //check the target with set of previous values
                while (target < previous && j >= 0)
                {
                    //swap the values
                    array[j] = target;
                    array[j + 1] = previous;
                    //reset previous
                    if (j > 0)
                    {
                        previous = array[j - 1];
                    }

                    j = j - 1;

                }

            }
            return array;
        }


        /// <summary>
        /// Printing the arrays before the sorting
        /// </summary>
        /// <param name="array"></param>
        public static void PreSortArray(int[] array)
        {
            Console.WriteLine("Before sorting the Array");

            Console.WriteLine($"{string.Join(", ", array)}");

        }

        /// <summary>
        /// Print the Values in the Array
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(int[] array)
        {
            Console.WriteLine("After sorting the Array");

            Console.WriteLine($"{string.Join(", ", array)}");

        }

       

    }
}
