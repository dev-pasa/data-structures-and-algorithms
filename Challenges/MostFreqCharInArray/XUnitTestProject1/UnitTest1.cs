using System;
using System.Collections.Generic;
using System.Linq;
using MostFrequentChar;
using Xunit;

namespace XUnitTestProject1
{
    //Test the Method by passing string input
    public class MostFrequenctCharTest
    {
        [Theory]
        [InlineData('l', "Hello World!")]
        [InlineData('l', "Hello Hello!")]
        [InlineData('s', "best of best things")]
        [InlineData('l', "all apple")]
        [InlineData('a', "aazzaabbb")]
        public void Test1(char result, string input)
        {
            //Assert result is same as the result output from method
            var output = Program.SingleMostFreqChar(input);
            Assert.Equal(result, output);
        }
    }
}
