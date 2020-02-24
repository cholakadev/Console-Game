namespace Game.Characters.Monsters
{
    using Game.Methods;
    public class Boss : IEnemy
    {
        public Boss()
        {
            this.Name = "Goblin's Head";
            this.Damage = 30;
            this.Health = 100;
        }

        public string Name { get; private set; }

        public int Damage { get; private set; }

        public int Health { get; private set; }
    }
}
