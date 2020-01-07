namespace Game.Characters.Monsters
{
    using Game.Methods;
    public class Boss : Character
    {
        public Boss() : base("Goblins's Imperator", UtilityMethods.Random(5, 12), UtilityMethods.Random(50, 60))
        {

        }
    }
}
