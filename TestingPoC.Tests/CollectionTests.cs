using TestingPoc;
using Xunit;

namespace TestingPoC.Tests
{
    public class CollectionTests
    {
        [Fact]
        public void ShouldHaveNoEmptyWeapons()
        {
            var sut = new PlayerCharacter();
            Assert.All(sut.Weapons, weapon => Assert.False(string.IsNullOrWhiteSpace(weapon)));
        }

        [Fact]
        public void ShouldHaveALongBow()
        {
            var sut = new PlayerCharacter();
            Assert.Contains("Long bow", sut.Weapons);
        }

        [Fact]
        public void ShouldNotHaveAStaffOfWonder()
        {
            var sut = new PlayerCharacter();
            Assert.DoesNotContain("Staff of wonder", sut.Weapons);
        }

        [Fact]
        public void ShouldHaveAtLeastOneKindOfSword()
        {
            var sut = new PlayerCharacter();
            Assert.Contains(sut.Weapons, weapon => weapon.Contains("sword"));
        }

        [Fact]
        public void ShouldHaveAllExpectedWeapons()
        {
            var sut = new PlayerCharacter();

            var weapons = new[]
            {
                "Short bow",
                "Long bow",
                "Short sword"
            };

            Assert.Equal(weapons, sut.Weapons);
        }
    }
}
