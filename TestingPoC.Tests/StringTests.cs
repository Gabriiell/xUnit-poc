using TestingPoc;
using Xunit;

namespace TestingPoC.Tests
{
    public class StringTests
    {
        [Fact]
        public void ShouldJoinNames()
        {
            var sut = new NameJoiner();
            var result = sut.Join("Sarah", "Smith");
            Assert.Equal("Sarah Smith", result);
        }

        [Fact]
        public void ShouldJoinNamesCaseInsensitive()
        {
            var sut = new NameJoiner();
            var result = sut.Join("sarah", "smith");
            Assert.Equal("SARAH SMITH", result, ignoreCase: true);
        }

        [Fact]
        public void ShouldContainFirstNameAfterJoining()
        {
            var sut = new NameJoiner();
            var result = sut.Join("Sarah", "Smith");
            Assert.Contains("Sarah", result);
        }

        [Fact]
        public void ShouldEndWithLastNameAfterJoining()
        {
            var sut = new NameJoiner();
            var result = sut.Join("Sarah", "Smith");
            Assert.EndsWith("Smith", result);
        }

        [Fact]
        public void ShouldBeValidFullNameAfterJoining()
        {
            var sut = new NameJoiner();
            var result = sut.Join("Sarah", "Smith");
            Assert.Matches("[A-Z][a-z]+ [A-Z][a-z]+", result);
        }
    }
}
