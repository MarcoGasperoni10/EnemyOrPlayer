using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.EnemyOrPlayer.Domain
{
    public class Player
    {
        private int _level;

        public string Name { get; set; }

        public int Level
        {
            get { return _level; }
            private set
            {
                if (value < 1)
                    _level = 1;
            }
        }

        public int Experience { get; private set; }

        public int Health { get; private set; }

        public int MaxHealth { get; private set; }

        public bool IsAlive { get; private set; }

        public int Gold { get; private set; }

        public Player(string name)
        {
            Name = name;
            Level = 1;
            Experience = 0;
            MaxHealth = 100;
            Health = MaxHealth;
            IsAlive = true;
            Gold = 0;
        }

        public void AddExperience(int expAdded)
        {
            if (expAdded < 0)
                throw new ArgumentException($"value not allowed {nameof(expAdded)}: {expAdded}");
            Experience += expAdded;
            if (Experience >= 100)
            {
                Experience -= 100;
                Level += 1;
            }
        }

        public void ResetExperience()
        {
            Experience = 0;
        }

        public void TakeDamage(int damageTaken)
        {
            if (damageTaken < 0)
                throw new ArgumentException($"value not allowed {nameof(damageTaken)}: {damageTaken}");

            Health -= damageTaken;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void Heal(int healAmount)
        {
            if (healAmount < 0)
                throw new ArgumentException($"value not allowed {nameof(healAmount)}: {healAmount}");
            Health += healAmount;
        }

        public void AddGold(int goldAmount)
        {
            if (goldAmount < 0)
                throw new ArgumentException($"value not allowed {nameof(goldAmount)}: {goldAmount}");
        }

        public void ResetHealth()
        {
            Health = MaxHealth;
        }
    }
}