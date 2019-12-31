namespace Game.Characters
{
    using Game.Methods;
    public class Monster : Character
    {
        public Monster() : base("Goblin", 0, UtilityMethods.Random(30, 40))
        {

        }
    }
}
