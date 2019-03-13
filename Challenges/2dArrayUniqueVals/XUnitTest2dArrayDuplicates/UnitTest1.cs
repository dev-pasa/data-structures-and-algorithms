using System;
using Xunit;
using UniqueVals;
using System.Collections.Generic;

namespace XUnitTest2dArrayDuplicates
{
    public class UnitTest1
    {
        /// <summary>
        /// Test the method on a 2d array
        /// </summary>
        [Fact]
        public void CheckDuplicatesTest1()
        {
            int[,] input = new int[,] { { 1, 2, 3, 4, 5 }, { 4, 5, 6, 7, 8 }, { 6, 7, 8, 9, 10 } };
            List<int> Output = Program.UniqueVals(input);
            Assert.Equal(10, Output.Count);
        }

        /// <summary>
        /// Test the method on a 2d array
        /// </summary>
        [Fact]
        public void CheckDuplicatesTest2()
        {
            int[,] input = new int[,] { { 11, 12, 13, 14, 15 }, { 14, 15, 16, 17, 18 }, { 16, 17, 18, 19, 20 } };
            List<int> Output = Program.UniqueVals(input);
            Assert.Equal(10, Output.Count);
        }

        /// <summary>
        /// Test the method on a 2d array
        /// </summary>
        [Fact]
        public void CheckDuplicatesTest3()
        {
            int[,] input = new int[,] { { 1, 2, 3, 4}, { 4, 5, 6, 7 }, { 6, 7, 8, 9 } };
            List<int> Output = Program.UniqueVals(input);
            Assert.Equal(9, Output.Count);
        }
    }
}
