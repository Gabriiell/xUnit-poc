using TestingPoc;
using Xunit;

namespace TestingPoC.Tests
{
    public class DataDrivenTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 0, 1)]
        [InlineData(1, -4, -3)]
        public void ShouldAddIntValues(int first, int second, int expectedResult)
        {
            var sut = new Calculator();
            var result = sut.Add(first, second);
            Assert.Equal(expectedResult, result);
        }
    }
}
