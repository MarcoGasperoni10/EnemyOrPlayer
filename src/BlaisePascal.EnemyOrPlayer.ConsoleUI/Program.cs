using BlaisePascal.EnemyOrPlayer.Domain;
using System.Numerics;

namespace BlaisePascal.EnemyOrPlayer.UIConsole
{
    internal class Program
    {
        public static void Main()
        {
            Enemy enemy = new Enemy("Goblin", 100, 25);

            Console.WriteLine(enemy.Name);

            Console.WriteLine($"Il nemico è vivo? {enemy.IsAlive()}");

            enemy.TakeDamage(30);

            Console.WriteLine(enemy.Name);

            Console.WriteLine($"Il nemico è vivo? {enemy.IsAlive()}");

            Player player = new Player("Link");

            int experience = player.Experience;

            Console.WriteLine($"Esperienza dopo l'aggiunta: {experience}");

            player.AddGold(50);
            Console.WriteLine($"Oro del giocatore: {player.Gold}");

            player.TakeDamage(30);

            player.Heal(20);

            player.TakeDamage(100);

            Console.WriteLine($"Il giocatore è vivo? {player.IsAlive}");

            player.ResetHealth();

            player.ResetExperience();
        }
    }
}