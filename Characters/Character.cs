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
            set
            {
                if (value < 0)
                {
                    throw new Exception("Damage must be a positive number.");
                }

                this.damage = value;
            }
        }
        public int Health { get; set; }

        public void DefaultValues()
        {
            this.Health = 30;
        }
    }
}
