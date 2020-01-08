namespace Game.Characters
{
    using System;

    public abstract class Character
    {
        private string name;
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
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Player name must be at least 3 symbols.", "Name");
                }

                this.name = value;
            }
        }
        public int Damage { get; set; }
        public int Health { get; set; }
    }
}
