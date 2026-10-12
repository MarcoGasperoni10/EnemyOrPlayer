using System.ComponentModel;

namespace BlaisePascal.EnemyOrPlayer.Domain
{
    public class Enemy
    {
        private int _health;

        public string Name { get; set; }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > 100)
                {
                    _health = 100;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public int Damage { get; private set; }

        public Enemy(string name, int health, int damage)
        {
            if (String.IsNullOrWhiteSpace(name) == true)
                throw new ArgumentException($"value not allowed {nameof(name)}: {name}");
            Name = name;
            if (Health < 0)
                throw new ArgumentException($"value not allowed {nameof(health)}: {health}");
            Health = health;
            if (Damage < 0)
                throw new ArgumentException($"value not allowed {nameof(damage)}: {damage}");
            Damage = damage;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentException($"value not allowed {nameof(damage)}: {damage}");
            Health -= damage;
        }
    }
}