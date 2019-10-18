using System;
using TestingPoc;
using Xunit;
using Xunit.Abstractions;

namespace TestingPoC.Tests
{
    public class MemoryCalculatorFixture : IDisposable
    {
        public MemoryCalculator Sut { get; private set; } = new MemoryCalculator();

        public void Dispose()
        {
            Sut.Dispose();
        }
    }

    public class MemoryCalculatorTests : IClassFixture<MemoryCalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly MemoryCalculatorFixture _fixture;

        public MemoryCalculatorTests(ITestOutputHelper testOutputHelper, MemoryCalculatorFixture fixture)
        {
            _testOutputHelper = testOutputHelper;
            _fixture = fixture;

            _fixture.Sut.Clear();
        }

        [Fact]
        public void ShouldAdd()
        {
            var sut = _fixture.Sut;

            _testOutputHelper.WriteLine("Executing should add");
            sut.Add(10);
            sut.Add(5);
            Assert.Equal(15, sut.CurrentValue);
        }

        [Fact]
        public void ShouldDivide()
        {
            var sut = _fixture.Sut;

            _testOutputHelper.WriteLine("Executing should divide");
            sut.Add(10);
            sut.Divide(2);
            Assert.Equal(5, sut.CurrentValue);
        }
    }
}
