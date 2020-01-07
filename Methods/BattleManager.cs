namespace Game.Methods
{
    using Game.Characters;
    public sealed class BattleManager
    {
        public static void Fight(Player player, Monster monster)
        {
            if (player.Level <= 2)
            {
                player.Damage = UtilityMethods.Random(5, 12);
                player.DamageAbsorb = UtilityMethods.Random(1, 4);
            }

            else if (player.Level > 2 && player.Level <= 4)
            {
                player.Damage = UtilityMethods.Random(7, 14);
                player.DamageAbsorb = UtilityMethods.Random(2, 5);
            }

            monster.Damage = UtilityMethods.Random(5, 14);

            player.Health -= monster.Damage - player.DamageAbsorb;

            monster.Health -= player.Damage;
        }
    }
}
