using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 8, 15, 16, 23, 42};
            int key = 8;
            int val = BinarySearch(array, key);
            Console.WriteLine(val);
        }

       /// <summary>
       /// Do a binary search in the array to test whether the value is present
       /// </summary>
       /// <param name="array"></param>
       /// <param name="key"></param>
       /// <returns></returns>
        public static int BinarySearch(int[] array, int key)
        {
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {      
                //get the mid index of the array
                int mid = (min + max) / 2;
                //if the mide index is the value return the value
                if (array[mid] == key) return mid;

                else if (array[mid] < key) min = mid+1;
                
                else if (array[mid] > key) max = mid-1;
                              
            }
            return -1;
        }
    }
}
