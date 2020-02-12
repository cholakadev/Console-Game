namespace Game.Characters
{
    using Game.Methods;
    public class Battle
    {
        public void FightEngine(Player player, Monster monster)
        {
            monster.Damage = UtilityMethods.Random(5, 14);

            player.Health -= monster.Damage - player.DamageAbsorb;

            monster.Health -= player.Damage;
        }
    }
}
