namespace Game
{
    using System;
    public class Methods
    {
        public static void FightResults(Player pl1, Player pl2)
        {
            Console.WriteLine($"{pl1.Name} hit {pl2.Name} and dealing {pl1.Damage} damage. {pl2.Name} left with {pl2.Health} health!");
            Console.WriteLine($"{pl2.Name} hit {pl1.Name} and dealing {pl2.Damage} damage. {pl1.Name} left with {pl1.Health} health!");
        }

        public static void FightValues(Player pl1, Player pl2)
        {
            pl1.Damage = pl1.Random(5, 12);
            pl2.Damage = pl2.Random(5, 12);

            pl1.DamageAbsorb = pl1.Random(1, 4);
            pl2.DamageAbsorb = pl2.Random(1, 4);

            pl1.Health -= pl2.Damage - pl1.DamageAbsorb;
            pl2.Health -= pl1.Damage - pl2.DamageAbsorb;
        }

        public static void Experiance(Player pl)
        {
            if (pl.Level <= 3)
            {
                pl.Experiance += 60;
            }
            else if (pl.Level > 3 && pl.Level <= 6)
            {
                pl.Experiance += 30;
            }

            else if (pl.Level > 6)
            {
                pl.Experiance += 15;
            }

            if (pl.Experiance >= 100)
            {
                pl.Level++;
                pl.Experiance = pl.Experiance - 100;
                Console.WriteLine($"{pl.Name} has reached level {pl.Level}");
            }

        }
    }
}
