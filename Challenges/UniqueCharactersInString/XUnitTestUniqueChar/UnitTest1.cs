using System;
using Xunit;
using UniqueCharcter;

namespace XUnitTestUniqueChar
{
    public class UnitTest1
    {
        /// <summary>
        /// First test that shoudl return true for all unique characters
        /// </summary>
        [Fact]
        public void UniqueCharinStringTest1()
        {
            Assert.True(Program.UniqueCharacters("Helo"));
        }
        /// <summary>
        /// First test that shoudl return false for all unique characters
        /// </summary>
        [Fact]
        public void UniqueCharinStringTest2()
        {
            Assert.False(Program.UniqueCharacters("lll"));
        }
        /// <summary>
        /// First test that shoudl return true for all unique characters
        /// </summary>
        [Fact]
        public void UniqueCharinStringTest3()
        {
            Assert.True(Program.UniqueCharacters("World"));
        }
    }
}
