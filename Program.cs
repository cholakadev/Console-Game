using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Program : Methods
    {
        public Program()
        {
        }

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
                    if (pl.Health <= 0)
                    {
                        Console.WriteLine("You died!");
                        break;
                    }
                    else if (monster.Health <= 0)
                    {
                        Console.WriteLine("Goblin died!");
                        break;
                    }

                    FightMonsterValues(pl, monster);

                    FightResults(pl, monster);
                }

                if (pl.Level == 5)
                {
                    Console.WriteLine($"{pl.Name} has reached max level! Congratulations!");
                    break;
                }

                Console.WriteLine("-------------------------------");

                // Set to default values.
                pl.Health = 30;
                monster.Health = monster.Random(30, 40);

                inputCommand = Console.ReadLine()
                    .Split()
                    .ToArray();
            }
        }
    }
}
