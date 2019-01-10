using System;
using Xunit;
using Fibonacci;

namespace XUnitFibTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Fibonacci()
        {
            //arrange
            int key = 2;

            //act

            //asserted
            Assert.Equal(1, Program.Fibonacci(key));
        }

        [Theory]
        [InlineData(9)]

        public void Fibonacci2(int val)
        {
            Assert.Equal(34, Program.Fibonacci(val));
        }

        [Theory]
        [InlineData(10)]

        public void Fibonacci3(int val)
        {
            Assert.Equal(55, Program.Fibonacci(val));
        }
    }
}
