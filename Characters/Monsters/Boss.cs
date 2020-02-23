namespace Game.Characters.Monsters
{
    using Game.Methods;
    public class Boss : IEnemy
    {
        public string Name { get; private set; }

        public int Damage { get; private set; }

        public int Health { get; private set; }
    }
}
