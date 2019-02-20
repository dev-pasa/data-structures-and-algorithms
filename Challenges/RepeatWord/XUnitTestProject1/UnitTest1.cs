using System;
using Xunit;
using Repeatword;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void NoRepeat()
        {
            string input = " No repeat word";
            Assert.Equal("Not Found", Program.RepeatWord(input));
        }

        [Fact]
        public void Repeat1()
        {
            string input = " A for apple, a for all";
            Assert.Equal("a", Program.RepeatWord(input));
        }

        [Fact]
        public void Repeat2()
        {
            string input = " No women no cry";
            Assert.Equal("no", Program.RepeatWord(input));
        }

    }
}
