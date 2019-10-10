using TestingPoc;
using Xunit;

namespace TestingPoC.Tests
{
    public class NumericTests
    {
        [Fact]
        public void ShouldAddIntValues()
        {
            var sut = new Calculator();
            var result = sut.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void ShouldAddDoubleValues()
        {
            var sut = new Calculator();
            var result = sut.AddDoubles(1.1, 2.2);
            Assert.Equal(3.3, result, 1);
        }
    }
}
