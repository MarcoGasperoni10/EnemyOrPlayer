using BlaisePascal.EnemyOrPlayer.Domain;
using System.Numerics;

namespace BlaisePascal.EnemyOrPlayer.UIConsole
{
    internal class Program
    {
        public static void Main()
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Player player3 = new Player();
            Player player4 = new Player();
            Player player5 = new Player();
            Player player6 = new Player();

            Console.WriteLine(player1.Name);
            Console.WriteLine(player2.Name);
            Console.WriteLine(player3.Name);
            Console.WriteLine(player4.Name);
            Console.WriteLine(player5.Name);
            Console.WriteLine(player6.Name);
        }
    }
}