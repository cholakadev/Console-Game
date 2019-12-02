namespace Game
{
    using System;
    using System.Linq;
    public class StartGame
    {
        public void Start(Player pl, Monster monster, PlayerData playerData)
        {
            CheckCommand(pl, monster, playerData);
        }

        private void CheckCommand(Player pl, Monster monster, PlayerData playerData)
        {
            string[] inputCommand = Console.ReadLine().Split().ToArray();
            string command = inputCommand[0];
            string action = inputCommand[1];

            while (true)
            {
                if (command.ToLower() == "fight" && action.ToLower() == "monster")
                {
                    CheckWhoDied(pl, monster);
                    if (pl.Level == 8)
                    {
                        Console.WriteLine($"{pl.Name} have reached max level!");
                        break;
                    }
                    SetToDefaultValues(pl, monster);
                }
                if (command.ToLower() == "player" && action.ToLower() == "stats")
                {
                    PlayerManager.PlayerStats(pl, playerData);
                }
                Console.WriteLine("---------------------------------------");

                inputCommand = Console.ReadLine().Split().ToArray();
                command = inputCommand[0];
                action = inputCommand[1];
            }
        }

        private void SetToDefaultValues(Player pl, Monster monster)
        {
            pl.Health = 30;
            monster.Health = UtilityMethods.Random(30, 40);
        }

        private void CheckWhoDied(Player pl, Monster monster)
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
        }
    }
}
