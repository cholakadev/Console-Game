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
            //PlayerData plData = new PlayerData();

            List<string> pl1Data = Console.ReadLine()
                    .Split()
                    .ToList();

            var pl1Name = pl1Data[0];
            Player pl1 = new Player(pl1Name);

            List<string> pl2Data = Console.ReadLine()
                .Split()
                .ToList();

            var pl2Name = pl2Data[0];
            Player pl2 = new Player(pl2Name);

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                if (command.ToLower() == "fight")
                {
                    int countRounds = 1;
                    while (true)
                    {
                        if (pl1.Health <= 0)
                        {
                            Experiance(pl2);
                            Console.WriteLine($"{pl2.Name} has won!");
                            break;
                        }

                        else if (pl2.Health <= 0)
                        {
                            Experiance(pl1);
                            Console.WriteLine($"{pl1.Name} has won!");
                            break;
                        }

                        FightValues(pl1, pl2);
                        Console.WriteLine($"Round {countRounds}");
                        FightResults(pl1, pl2);
                        Console.WriteLine("---------------------------------------------------------------");
                        countRounds++;
                    }
                    // Set to default health values.
                    pl1.Health = 20;
                    pl2.Health = 20;
                }

                command = Console.ReadLine();
            }
        }
    }
}
