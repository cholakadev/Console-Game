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

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                if (command.ToLower() == "fight")
                {
                    int countRounds = 1;
                    while (true)
                    {
                        if (pl.Health <= 0)
                        {
                            if (pl.Experiance >= 0)
                            {
                                pl.Experiance -= 10;
                            }
                            Console.WriteLine($"{pl.Name} died!");
                            break;
                        }

                        else if (monster.Health <= 0)
                        {
                            Experiance(pl);
                            Console.WriteLine($"{monster.Name} died!");
                            //Console.WriteLine("Loot.......");
                            break;
                        }

                        FightValues(pl, monster);
                        Console.WriteLine($"Round {countRounds}");
                        FightResults(pl, monster);
                        Console.WriteLine("---------------------------------------------------------------");
                        countRounds++;
                    }
                    // Set to default values.
                    pl.Health = 30;
                    monster.Health = monster.Random(30, 40);
                }

                command = Console.ReadLine();
            }
        }
    }
}
