using System;
using Xunit;
using ArrayShift;

namespace XUnitTestArrayShift
{
    public class UnitTest1
    {
        /// <summary>
        /// Test in the first set of array
        /// </summary>
        [Fact]
        public void ArrayShiftTest1()
        {
            int[] input = { 1, 2, 4, 6, 7, 8, 9 };
            int[] result = { 1, 2, 4, 5, 6, 7, 8, 9 };
            Assert.Equal(result, Program.ArrayInsert(input, 5));
        }

        /// <summary>
        /// Test in the second set of array
        /// </summary>
        [Fact]
        public void ArrayShiftTest2()
        {
            int[] input = { 11, 12, 14, 16, 17, 18, 19 };
            int[] result = { 11, 12, 14, 15, 16, 17, 18, 19 };
            Assert.Equal(result, Program.ArrayInsert(input, 15));
        }
        /// <summary>
        /// Test in the third set of array
        /// </summary>
        [Fact]
        public void ArrayShiftTest3()
        {
            int[] input = { 31, 32, 34, 36, 37, 38, 39 };
            int[] result = { 31, 32, 34, 35, 36, 37, 38, 39 };
            Assert.Equal(result, Program.ArrayInsert(input, 35));
        }
    }

}
