namespace Game
{
    using System;
    public class Methods
    {
        public static void FightResults(Player pl, Monster monster)
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

        public static void FightMonsterValues(Player pl, Monster monster)
        {
            pl.Damage = pl.Random(5, 12);
            monster.Damage = monster.Random(5, 12);

            pl.DamageAbsorb = pl.Random(1, 4);

            pl.Health -= monster.Damage - pl.DamageAbsorb;

            monster.Health -= pl.Damage;
        }

        public static void Experience(Player pl)
        {
            int exp = 0;

            if (pl.Level < 3)
            {
                exp = 60;
                pl.Damage = Random(5, 12);
                pl.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }
            else if (pl.Level >= 3 && pl.Level < 6)
            {
                exp = 30;
                pl.Damage = Random(6, 14);
                pl.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            else if (pl.Level >= 6)
            {
                exp = 15;
                pl.Damage = Random(8, 15);
                pl.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            if (pl.Experience >= 100)
            {
                pl.Level++;
                pl.Experience = pl.Experience - 100;
                if (pl.Level < 5)
                {
                    Console.WriteLine($"{pl.Name} has reached level {pl.Level}");
                }
            }
        }

        public static int Random(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }

        public static void LoseExperiance(Player pl, int exp)
        {
            Console.WriteLine($"You lost {exp}% experiance!");
            if (pl.Experience >= 0)
            {
                pl.Experience -= exp;
            }
        }
    }
}
