using BlaisePascal.EnemyOrPlayer.Domain;
using System.Numerics;
using System.Text;

namespace BlaisePascal.EnemyOrPlayer.UnitTests
{
    public class PlayerTests
    {
        [Fact]
        public void Player_LevelStartsAtOne_LevelUpdated()
        {
            // Arrange - Act (Call to constructor in this scenario)
            Player player = new Player();

            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void Player_NameEmpty_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Player(""));
        }

        [Fact]
        public void Player_NameBlank_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Player("   "));
        }

        [Fact]
        public void Player_NameNotBlankOrEmpty_NameUpdated()
        {
            Player player = new Player("Luca Pulga");

            Assert.Equal("Luca Pulga", player.Name);
        }

        [Fact]
        public void AddExperience_ExpAddedLessThan0_ArgumentException()
        {
            Player player = new Player();

            Assert.Throws<ArgumentException>(() => player.AddExperience(-23));
        }

        [Fact]
        public void AddExperience_ExpAddedGreaterThan0_ExperienceUpdated()
        {
            Player player = new Player();
            player.AddExperience(25);

            Assert.Equal(25, player.Experience);
        }

        [Fact]
        public void TakeDamage_DamageTakenLessThan0_ArgumentException()
        {
            Player player = new Player();

            Assert.Throws<ArgumentException>(() => player.TakeDamage(-23));
        }

        [Fact]
        public void TakeDamage_DamageTakenGreaterThan0_HealthUpdated()
        {
            Player player = new Player();
            player.TakeDamage(25);

            Assert.Equal(75, player.Health);
        }

        [Fact]
        public void Heal_HealAmountLessThan0_ArgumentException()
        {
            Player player = new Player();
            player.TakeDamage(50);

            Assert.Throws<ArgumentException>(() => player.Heal(-4));
        }

        [Fact]
        public void Heal_HealAmountGreaterThan0_HealthUpdated()
        {
            Player player = new Player();
            player.TakeDamage(50);
            player.Heal(10);

            Assert.Equal(60, player.Health);
        }

        [Fact]
        public void AddGold_GoldAmountLessThan0_ArgumentException()
        {
            Player player = new Player();

            Assert.Throws<ArgumentException>(() => player.AddGold(-5142381));
        }

        [Fact]
        public void AddGold_GoldAmountGreaterThan0_GoldUpdated()
        {
            Player player = new Player();
            player.AddGold(250);

            Assert.Equal(250, player.Gold);
        }
    }
}