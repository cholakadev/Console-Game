namespace Game.Methods
{
    using System;
    using Game.Characters;
    public sealed class BattleManager
    {
        public static void PrintBattleResults(Player player, Monster monster)
        {
            if (player.Health < monster.Health)
            {
                Console.WriteLine($"{monster.Name} has slain {player.Name} and left with {monster.Health} health!");
            }

            else if (monster.Health < player.Health)
            {
                Console.WriteLine($"{player.Name} has slain {monster.Name} and left with {player.Health} health!");
            }
        }

        public static void Fight(Player player, Monster monster)
        {
            player.Damage = UtilityMethods.Random(5, 12);

            monster.Damage = UtilityMethods.Random(5, 12);

            player.DamageAbsorb = UtilityMethods.Random(1, 4);

            player.Health -= monster.Damage - player.DamageAbsorb;

            monster.Health -= player.Damage;
        }
    }
}
