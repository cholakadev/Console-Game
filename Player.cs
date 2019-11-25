namespace Game
{
    using System;
    public class Player
    {
        public Player(string name)
        {
            this.Experience = 0;
            this.Level = 1;
            this.Name = name;
            this.Health = 30;
            this.Damage = 0;
            this.DamageAbsorb = 0;
        }

        public int Experience { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int DamageAbsorb { get; set; }

        public int Random(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }
    }
}
