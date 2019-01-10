using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 8, 15, 16, 23, 42};
            int key = 15;
            int val = BinarySearch(array, key);
            Console.WriteLine(val);
        }

        public static int BinarySearch(int[] array, int key)
        {
            int min = 0;
            int max = array.Length - 1;
            int mid = (min + max) / 2;

            while(min < max)
            {
                
                if(array[mid] < key) min = mid + 1;
                
                else if (array[mid] > key) max = mid - 1;
                
                else if (array[mid] == key) return mid;
            }
            return -1;
        }
    }
}
