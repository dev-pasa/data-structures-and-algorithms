using System;
using Xunit;
using WordReverse;

namespace XUnitTestReverseChars
{
    public class UnitTest1
    {
        /// <summary>
        /// Test the reverse method on a given input
        /// </summary>
        [Fact]
        public void ReverseString1()
        {
            String input = "Hello World";
            String output = "dlroW olleH";

            Assert.Equal(output, Program.ReverseCharsInWord(input));
        }

        /// <summary>
        /// Test the reverse method on a given input
        /// </summary>
        [Fact]
        public void ReverseSting2()
        {
            String input = "Hello";
            String output = "olleH";

            Assert.Equal(output, Program.ReverseCharsInWord(input));
        }


        /// <summary>
        /// Test the reverse method on a given input
        /// </summary>
        [Fact]
        public void ReverseString3()
        {
            String input = "How are you?";
            String output = "?uoy era woH";

            Assert.Equal(output, Program.ReverseCharsInWord(input));
        }
    }
}
