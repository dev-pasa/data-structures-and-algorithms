using System;
using Xunit;
using MultiBrackValidation;

namespace XUnitTestMultiBracketTest
{
    public class UnitTest1
    {
       
        [Theory]
        [InlineData("{}()[]")]
        [InlineData("{}(eere)[]()")]
        [InlineData("{}()[][][][]")]
        public void CheckTrueVals(string input)
        {
            //Assert
            Assert.True(Program.MultiBracketValidation(input));
        }

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
