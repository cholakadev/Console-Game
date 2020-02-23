namespace Game.Characters
{
    using Game.Methods;
    public class Monster : IEnemy
    {
        public Monster()
        {
            this.Name = "Goblin";
            this.Damage = UtilityMethods.Random(5, 14);
            this.Health = UtilityMethods.Random(30, 40);
        }

        public string Name { get; private set; }

        public int Damage { get; private set; }

        public int Health { get; set; }

        public void MonsterDefaultValues()
        {
            this.Health = UtilityMethods.Random(30, 40);
        }
    }
}
