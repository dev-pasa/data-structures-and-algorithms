using System;
using Xunit;
using MultiBrackValidation;

namespace XUnitTestMultiBracketTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Check if the right inputs come up as true
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("{}()[]")]
        [InlineData("{}(eere)[]()")]
        [InlineData("{}()[][][][]")]
        public void CheckTrueVals(string input)
        {
            //Assert
            Assert.True(Program.MultiBracketValidation(input));
        }

        /// <summary>
        /// check if incorrect inputs come as false
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("{}()]")]
        [InlineData("{}(eere)[])")]
        [InlineData("{}()[][][]]")]
        public void CheckFalseVals(string input)
        {
            //Assert
            Assert.False(Program.MultiBracketValidation(input));
        }

    }
}
