namespace Game
{
    using System;
    public class Monster
    {
        public Monster()
        {
            this.Name = "Goblin";
            this.Damage = 0;
            this.Health = Random(30, 40);
        }
        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public int Random(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }
    }
}
