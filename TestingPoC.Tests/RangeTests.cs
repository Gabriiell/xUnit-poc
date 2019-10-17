using TestingPoc;
using Xunit;
using Xunit.Abstractions;

namespace TestingPoC.Tests
{
    public class RangeTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public RangeTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            _testOutputHelper.WriteLine("Creating Player");
            var sut = new PlayerCharacter { Health = 100 };

            _testOutputHelper.WriteLine("Player going to sleep");
            sut.Sleep();
            _testOutputHelper.WriteLine("Player awoken");

            Assert.InRange(sut.Health, 101, 200);
        }
    }
}
