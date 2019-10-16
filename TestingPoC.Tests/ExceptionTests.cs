using System;
using TestingPoc;
using Xunit;

namespace TestingPoC.Tests
{
    public class ExceptionTests
    {
        [Fact]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();
            Assert.Throws<DivideByZeroException>(() => sut.Divide(1, 0));
        }

        [Fact]
        public void ShouldErrorWhenNumberTooBig()
        {
            var sut = new Calculator();
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => sut.Divide(201, 2));
            Assert.Equal("value should be less than 200", exception.ParamName);
        }
    }
}
