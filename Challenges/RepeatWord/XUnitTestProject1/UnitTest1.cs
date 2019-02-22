using System;
using Xunit;
using Repeatword;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// check if it throws exception if no error found
        /// </summary>
        [Fact]
        public void NoRepeat()
        {
            string input = " No repeat word";
            Assert.Equal("No Repeat Found", Program.RepeatWord(input));
        }

        /// <summary>
        /// check for first repeat word
        /// </summary>
        [Fact]
        public void Repeat1()
        {
            string input = " A for apple, a for all";
            Assert.Equal("a", Program.RepeatWord(input));
        }

        /// <summary>
        /// check for first repeat word
        /// </summary>
        [Fact]
        public void Repeat2()
        {
            string input = " No women no cry";
            Assert.Equal("no", Program.RepeatWord(input));
        }

        /// <summary>
        /// check for first repeat word
        /// </summary>
        [Fact]
        public void Repeat3()
        {
            string input = " hi hello hi hi";
            Assert.Equal("hi", Program.RepeatWord(input));
        }

    }
}
