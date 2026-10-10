using BlaisePascal.EnemyOrPlayer.Domain;
using System.Numerics;
using System.Text;

namespace BlaisePascal.EnemyOrPlayer.UnitTests
{
    public class PlayerTests
    {
        [Fact]
        public void Player_()
        {
            // Arrange - Act (Call to constructor in this scenario)
            Player player = new Player();

            Assert.Equal(1, player.Level);
        }
    }
}
