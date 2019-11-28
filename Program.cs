using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Weapon weapon = new Weapon();

            List<string> plData = Console.ReadLine()
                    .Split()
                    .ToList();

            var plName = plData[0];
            Player pl = new Player(plName);

            Monster monster = new Monster();

            string[] inputCommand = Console.ReadLine()
                .Split()
                .ToArray();

            while (true)
            {
                if (inputCommand[0].ToLower() == "fight" && inputCommand[1].ToLower() == "monster")
                {
                    while (true)
                    {
                        BattleManager.Fight(pl, monster);

                        if (pl.Health <= 0)
                        {
                            BattleManager.PrintFightResults(pl, monster);
                            pl.LoseExperiance(pl, 10);
                            break;
                        }

                        else if (monster.Health <= 0)
                        {
                            BattleManager.PrintFightResults(pl, monster);
                            pl.EarnExperience(pl);
                            LootManager.DropSilver(pl);
                            break;
                        }
                    }

                    if (pl.Level == 5)
                    {
                        Console.WriteLine("You have reached max level!");
                        break;
                    }

                    // Set to default values.
                    pl.Health = 30;
                    monster.Health = UtilityMethods.Random(30, 40);
                }

                Console.WriteLine("---------------------------------");

                inputCommand = Console.ReadLine()
                    .Split()
                    .ToArray();
            }
        }
    }
}
