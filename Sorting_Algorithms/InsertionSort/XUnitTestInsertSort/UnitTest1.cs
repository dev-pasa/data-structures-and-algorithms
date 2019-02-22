using System;
using Xunit;
using InsertionSortAlgorithm;

namespace XUnitTestInsertSort
{
    public class UnitTest1
    {
        /// <summary>
        /// tests to sort array with negative values
        /// </summary>
        [Theory]
        [InlineData(-5, 0)]
        [InlineData(-4, 1)]
        [InlineData(-3, 2)]
        [InlineData(-2, 3)]
        [InlineData(-1, 4)]
        public void NegativeSortTest(int expected, int index)
        {
            int[] InputArray = new int[5] { -1, -4, -3, -2, -5 };

            int[] testOutput = Program.InsertionSort(InputArray);

            Assert.Equal(expected, testOutput[index]);
        }

        /// <summary>
        /// tests to sort array with  array placed backward
        /// </summary>
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 4)]
        public void BackwardSortTest(int expected, int index)
        {
            int[] InputArray = new int[5] { 5, 4, 3, 2, 1 };

            int[] testOutput = Program.InsertionSort(InputArray);

            Assert.Equal(expected, testOutput[index]);
        }

        /// <summary>
        /// tests to sort array with  array placed backward
        /// </summary>
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 4)]
        public void SortTestAsIs(int expected, int index)
        {
            int[] InputArray = new int[5] { 1, 2, 3, 4, 5 };

            int[] testOutput = Program.InsertionSort(InputArray);

            Assert.Equal(expected, testOutput[index]);
        }

        /// <summary>
        /// Test1 for Insertion Sort
        /// </summary>
        [Fact]
        public void InsertSortTest1()
        {
            int[] array1 = { 2, 3, 4, 5, 1 };
            int[] output = Program.InsertionSort(array1);
            int[] result = { 1, 2, 3, 4, 5 };
            Assert.Equal(output, result);
        }

        /// <summary>
        /// Test2 for Insertion Sort
        /// </summary>
        [Fact]
        public void InsertSortTest2()
        {
            int[] array1 = { 2, 3, 4, 5, 1, 6 };
            int[] output = Program.InsertionSort(array1);
            int[] result = { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(output, result);
        }

        /// <summary>
        /// Test3 for Insertion Sort
        /// </summary>
        [Fact]
        public void InsertSortTest3()
        {
            int[] array1 = { 2, 3, 4, 5, 1, 7 };
            int[] output = Program.InsertionSort(array1);
            int[] result = { 1, 2, 3, 4, 5, 7 };
            Assert.Equal(output, result);
        }

       
    }
}
