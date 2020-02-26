namespace Game.Characters
{
    using Game.Characters.Monsters;
    using Game.Methods;
    public class Monster : EnemyCharacter, IEnemy
    {
        public Monster() : base("Goblin", UtilityMethods.Random(5, 13), UtilityMethods.Random(30, 40))
        {
        }

        public override void DefaultValues()
        {
            this.Health = UtilityMethods.Random(30, 40);
        }
    }
}
