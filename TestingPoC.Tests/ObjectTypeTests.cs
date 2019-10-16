using TestingPoc;
using Xunit;

namespace TestingPoC.Tests
{
    public class ObjectTypeTests
    {
        [Fact]
        public void ShouldCreateNormalEnemy()
        {
            var sut = new EnemyFactory();
            var enemy = sut.Create(false);
            var normalEnemy = Assert.IsType<NormalEnemy>(enemy);
            Assert.Equal(10, normalEnemy.ExtraPower);
        }

        [Fact]
        public void ShouldCreateEnemy()
        {
            var sut = new EnemyFactory();
            var enemy = sut.Create(false);
            var normalEnemy = Assert.IsAssignableFrom<Enemy>(enemy);
            Assert.Equal("Default Name", normalEnemy.Name);
        }
    }
}
