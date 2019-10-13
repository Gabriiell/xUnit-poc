using TestingPoc;
using Xunit;

namespace TestingPoC.Tests
{
    public class NullAndBoolTests
    {
        [Fact]
        public void ShouldHaveAGeneratedName()
        {
            var sut = new PlayerCharacter();
            Assert.False(string.IsNullOrWhiteSpace(sut.Name));
        }

        [Fact]
        public void ShouldNotHaveANickName()
        {
            var sut = new PlayerCharacter();
            Assert.Null(sut.NickName);
        }

        [Fact]
        public void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();
            Assert.True(sut.IsNoob);
        }
    }
}
