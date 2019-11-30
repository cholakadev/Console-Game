using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> plData = Console.ReadLine()
                    .Split()
                    .ToList();

            PlayerData playerData = new PlayerData();
            var plName = plData[0];
            Player pl = new Player(plName);
            playerData.Add(pl);

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

                        if (pl.Health <= 0 && pl.Health < monster.Health)
                        {
                            BattleManager.PrintFightResults(pl, monster);
                            pl.LoseExperiance(pl, 10);
                            break;
                        }

                        else if (monster.Health <= 0 && monster.Health < pl.Health)
                        {
                            BattleManager.PrintFightResults(pl, monster);
                            pl.EarnExperience(pl);
                            LootManager.DropSilver(pl);
                            break;
                        }
                    }

                    if (pl.Level == 8)
                    {
                        Console.WriteLine($"{pl.Name} have reached max level!");
                        break;
                    }

                    // Set to default values.
                    pl.Health = 30;
                    monster.Health = UtilityMethods.Random(30, 40);
                }

                if (inputCommand[0].ToLower() == "player" && inputCommand[1].ToLower() == "stats")
                {
                    PlayerManager.PlayerStats(pl, playerData);
                }

                Console.WriteLine("---------------------------------------");

                inputCommand = Console.ReadLine()
                    .Split()
                    .ToArray();
            }
        }
    }
}
