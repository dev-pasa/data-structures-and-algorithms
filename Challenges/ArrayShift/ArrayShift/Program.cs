using System;

namespace ArrayShift
{
   public class Program
    {
        /// <summary>
        /// test the ArrayInsert in the main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 4, 6, 7, 8, 9 };
            int value = 5;
            int[] newArr = ArrayInsert(array, value);
            for(int i = 0; i < newArr.Length; i++)
            {
                Console.Write($"{newArr[i]}, ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Insert a value to an array. 
        /// This method creates a new array with the given value added inside the current array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int[] ArrayInsert(int[] array , int value)
        {
            // create a new array with size one bigger than the previous array
           int[] newArr = new int [array.Length + 1];
            // get the length of the existing array passed into the method
            double arrLen =  array.Length;
            //get the mid of the array
            double mid = arrLen / 2;
            int midFixed = Convert.ToInt32(Math.Floor(mid));

            for(int i = 0; i < newArr.Length; i++)
            { 
                //our if conditions
                if(i == midFixed) newArr[i] = value;              
                else if (i > midFixed) newArr[i] = array[i - 1];              
                else newArr[i] = array[i]; 
            }
            return newArr;
        }
    }
}
