using System;
using Xunit;
using sorts;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
            
        /// <summary>
        /// Test1
        /// </summary>
        [Fact]
        public void InsertSortTest1()
        {
            int[] array1 = { 2, 3, 4, 5, 1 };
            int[]output = Program.InsertionSort(array1);
            int[] result = { 1, 2, 3, 4, 5 };
            Assert.Equal(output, result);
        }

        /// <summary>
        /// Test2
        /// </summary>
        [Fact]
        public void InsertSortTest2()
        {
            int[] array1 = { 2, 3, 4, 5, 1 , 6 };
            int[] output = Program.InsertionSort(array1);
            int[] result = { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(output, result);
        }

        /// <summary>
        /// Test3
        /// </summary>
        [Fact]
        public void InsertSortTest3()
        {
            int[] array1 = { 2, 3, 4, 5, 1, 7 };
            int[] output = Program.InsertionSort(array1);
            int[] result = { 1, 2, 3, 4, 5 , 7 };
            Assert.Equal(output, result);
        }
    }
}
