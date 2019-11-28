namespace Game
{
    using System;
    public class BattleManager
    {
        public static void PrintFightResults(Player pl, Monster monster)
        {
            if (pl.Health <= monster.Health)
            {
                Console.WriteLine($"{monster.Name} has slain {pl.Name} and left with {monster.Health} health!");
            }
            else if (monster.Health <= pl.Health)
            {
                Console.WriteLine($"{pl.Name} has slain {monster.Name} and left with {pl.Health} health!");
            }
        }

        public static void Fight(Player pl, Monster monster)
        {
            pl.Damage = UtilityMethods.Random(5, 12);
            monster.Damage = UtilityMethods.Random(5, 12);

            pl.DamageAbsorb = UtilityMethods.Random(1, 4);

            pl.Health -= monster.Damage - pl.DamageAbsorb;

            monster.Health -= pl.Damage;
        }
    }
}
