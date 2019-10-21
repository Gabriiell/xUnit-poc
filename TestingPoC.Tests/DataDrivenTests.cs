using System.Collections.Generic;
using TestingPoc;
using Xunit;

namespace TestingPoC.Tests
{
    public class CalculatorTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { 1, 1, 0 };
                yield return new object[] { 15, 6, 9 };
                yield return new object[] { 10, 11, -1 };
            }
        }
    }

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

        [Theory]
        [MemberData(nameof(CalculatorTestData.TestData), MemberType = typeof(CalculatorTestData))]
        public void ShouldSubstractIntValues(int first, int second, int expectedResult)
        {
            var sut = new Calculator();
            var result = sut.Substract(first, second);
            Assert.Equal(expectedResult, result);
        }
    }
}
