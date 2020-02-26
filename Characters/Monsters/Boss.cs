namespace Game.Characters.Monsters
{
    using Game.Methods;
    public class Boss : EnemyCharacter, IEnemy
    {
        public Boss() : base("Goblin's Head", 30, 100)
        {
        }

        public override void DefaultValues()
        {
            this.Health = 100;
        }
    }
}
