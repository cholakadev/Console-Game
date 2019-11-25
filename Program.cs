using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Program : Methods
    {
        public static void Main(string[] args)
        {
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
                    FightResults(pl, monster);

                    while (true)
                    {
                        if (pl.Health <= 0)
                        {
                            LoseExperiance(pl, 10);
                            break;
                        }

                        else if (monster.Health <= 0)
                        {
                            Experience(pl);
                            break;
                        }

                        FightMonsterValues(pl, monster);
                    }

                    if (pl.Level == 5)
                    {
                        Console.WriteLine("You have reached max level!");
                        break;
                    }

                    // Set to default values.
                    pl.Health = 30;
                    monster.Health = monster.Random(30, 40);
                }

                Console.WriteLine("---------------------------------");

                inputCommand = Console.ReadLine()
                    .Split()
                    .ToArray();
            }
        }
    }
}
