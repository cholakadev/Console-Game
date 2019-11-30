namespace Game
{
    public class Monster
    {
        public Monster()
        {
            this.Name = "Goblin";
            this.Damage = 0;
            this.Health = UtilityMethods.Random(30, 40);
        }
        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }
    }
}
