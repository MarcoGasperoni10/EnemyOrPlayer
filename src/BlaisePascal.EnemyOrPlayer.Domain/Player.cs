using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.EnemyOrPlayer.Domain
{
    public class Player
    {
        private string _name;
        private int _level;
        private int _experience;
        private int _health;
        private int _maxHealth;
        private bool _isAlive;
        private int _gold;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Level
        {
            get { return _level; }
            private set
            {
                if (value < 1)
                    _level = 1;
            }
        }

        public int Experience
        {
            get { return _experience; }
            private set { _experience = value; }
        }

        public int Health
        {
            get { return _health; }
            private set
            {
                _health = value;
                if (_health <= 0)
                    IsAlive = false;
            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            private set { _maxHealth = value; }
        }

        public bool IsAlive
        {
            get { return _isAlive; }
            private set { _isAlive = value; }
        }

        public int Gold
        {
            get { return _gold; }
            private set { _gold = value; }
        }

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