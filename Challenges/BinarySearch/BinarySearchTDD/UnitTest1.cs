using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTDD
{
    public class UnitTest1
    {

        [Fact]
        public void binarytest1()
        {
          //arrange
          int[] arr = new int[] { 4, 8, 15, 16, 23, 42 };
          int key = 8;

          //act

          //asserted
          Assert.Equal(1, Program.BinarySearch(arr, key));
        }

        [Theory]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 15)]

        public void BinaryTest2(int[] arr, int key)
        {
            Assert.Equal(3, Program.BinarySearch(arr, key));
        }

        [Theory]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 10)]

        public void BinaryTest3(int[] arr, int key)
        {
            Assert.Equal(-1, Program.BinarySearch(arr, key));
        }
    }
}
