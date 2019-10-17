using System;
using TestingPoc;
using Xunit;
using Xunit.Abstractions;

namespace TestingPoC.Tests
{
    public class MemoryCalculatorTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly MemoryCalculator _sut;

        public MemoryCalculatorTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;

            _testOutputHelper.WriteLine("Creating sut");
            _sut = new MemoryCalculator();
        }

        [Fact]
        public void ShouldAdd()
        {
            _testOutputHelper.WriteLine("Executing should add");
            _sut.Add(10);
            _sut.Add(5);
            Assert.Equal(15, _sut.CurrentValue);
        }

        [Fact]
        public void ShouldDivide()
        {
            _testOutputHelper.WriteLine("Executing should divide");
            _sut.Add(10);
            _sut.Divide(2);
            Assert.Equal(5, _sut.CurrentValue);
        }

        public void Dispose()
        {
            _testOutputHelper.WriteLine("Disposing sut");
            _sut.Dispose();
        }
    }
}
