namespace Game.Characters
{
    using Game.Methods;
    using System;
    public abstract class Character
    {
        private string name;
        private int damage;
        public Character(string name, int damage, int health)
        {
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Player name must be at least 3 symbols.", "Name");
                }

                this.name = value;
            }
        }
        public int Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Damage must be a positive number.");
                }

                this.damage = value;
            }
        }
        public int Health { get; private set; }

        public void DefaultValues(Player player, Monster monster)
        {
            player.Health = 30;
            monster.Health = UtilityMethods.Random(30, 40);
        }

        public void FightEngine(Player player, Monster monster)
        {
            monster.Damage = UtilityMethods.Random(5, 14);

            player.Health -= monster.Damage - player.DamageAbsorb;

            monster.Health -= player.Damage;
        }

        public void IncreaseDamage(Player player)
        {
            if (player.Level <= 2)
            {
                player.Damage = UtilityMethods.Random(5, 12);
            }

            else if (player.Level > 2 && player.Level <= 4)
            {
                this.Damage = UtilityMethods.Random(7, 14);
            }

            else if (player.Level > 4 && player.Level <= 6)
            {
                this.Damage = UtilityMethods.Random(9, 15);
            }

            else
            {
                this.Damage = UtilityMethods.Random(10, 17);
            }
        }
    }
}
