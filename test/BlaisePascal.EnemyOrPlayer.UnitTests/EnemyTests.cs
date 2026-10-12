using BlaisePascal.EnemyOrPlayer.Domain;
using System.Numerics;
using System.Text;

namespace BlaisePascal.EnemyOrPlayer.UnitTests
{
    public class EnemyTests
    {
        [Fact]
        public void Enemy_NameEmpty_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Enemy("", 100, 10));
        }

        [Fact]
        public void Enemy_NameBlank_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Enemy("    ", 100, 10));
        }

        [Fact]
        public void Enemy_NameNotBlankOrEmpty_NameUpdated()
        {
            Enemy enemy = new Enemy("Goblin", 100, 10);

            Assert.Equal("Goblin", enemy.Name);
        }

        [Fact]
        public void TakeDamage_DamageLessThan0_ArgumentException()
        {
            Enemy enemy = new Enemy("Red Boko", 13, 1);

            Assert.Throws<ArgumentException>(() => enemy.TakeDamage(-23));
        }

        [Fact]
        public void TakeDamage_DamageGreaterThan0_HealthUpdated()
        {
            Enemy enemy = new Enemy("Blue Boko", 72, 4);
            enemy.TakeDamage(10);

            Assert.Equal(62, enemy.Health);
        }
    }
}
