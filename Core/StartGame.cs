namespace Game.Core
{
    using System;
    using System.Linq;
    using InGameShop.Pets;
    using In_GameShop;
    using Game.InGameShop.Gems;
    using Game.Characters;
    using Game.Items;
    using Game.Methods;

    public class StartGame
    {
        public void Start(Player pl, Monster monster, PlayerData playerData)
        {
            GameBody(pl, monster, playerData);
        }

        private void GameBody(Player pl, Monster monster, PlayerData playerData)
        {
            // Load gears
            ItemManager items = new ItemManager();
            items.LoadItems();

            string[] inputCommand = Console.ReadLine().Split().ToArray();

            while (true)
            {
                string command = inputCommand[0];
                string action = inputCommand[1];

                bool fightMonster = command.ToLower() == "fight" && action.ToLower() == "monster";
                bool playerStats = command.ToLower() == "player" && action.ToLower() == "stats";
                bool inGameShop = command.ToLower() == "in-game" && action.ToLower() == "shop";

                if (fightMonster)
                {
                    try
                    {
                        CheckIfPlayerIsMaxLevel(pl, monster);
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }

                    SetToDefaultValues(pl, monster);
                }

                if (playerStats)
                {
                    PlayerManager.PlayerStats(pl, playerData);
                }

                if (inGameShop)
                {
                    Console.WriteLine($"Our in-game shop disposes with pets, gems and lucky box sections.");
                    string shopTab = Console.ReadLine();
                    PetTab petShop = new PetTab();
                    GemTab gemShop = new GemTab();

                    Shop(shopTab, petShop, gemShop);
                }
                Console.WriteLine();

                inputCommand = Console.ReadLine().Split().ToArray();
            }
        }

        private void CheckWhoDied(Player pl, Monster monster)
        {
            while (true)
            {
                BattleManager.Fight(pl, monster);

                if (pl.Health <= 0 && pl.Health < monster.Health)
                {
                    BattleManager.PrintBattleResults(pl, monster);
                    pl.LoseExperiance(pl, 10);
                    break;
                }

                else if (monster.Health <= 0 && monster.Health < pl.Health)
                {
                    BattleManager.PrintBattleResults(pl, monster);
                    pl.EarnExperience(pl);
                    LootManager.DropSilver(pl);
                    break;
                }
            }
        }

        private void CheckIfPlayerIsMaxLevel(Player pl, Monster monster)
        {
            if (pl.Level <= 8)
            {
                CheckWhoDied(pl, monster);
            }
            else
            {
                throw new ArgumentException($"{pl.Name} have reached max level!");
            }
        }

        private void SetToDefaultValues(Player pl, Monster monster)
        {
            pl.Health = 30;
            monster.Health = UtilityMethods.Random(30, 40);
        }

        private void Shop(string shopTab, PetTab petShop, GemTab gemShop)
        {
            while (true)
            {
                bool toExit = shopTab.ToLower() == "exit";
                bool toPetsTab = shopTab.ToLower() == "pets";
                bool toGemsTab = shopTab.ToLower() == "gems";

                if (toExit)
                {
                    break;
                }

                if (toPetsTab)
                {
                    petShop.AddPet(petShop);
                    petShop.PrintPetTab(petShop);
                    shopTab = Console.ReadLine();
                }

                if (toGemsTab)
                {
                    gemShop.AddGems(gemShop);
                    gemShop.PrintGemTab(gemShop);
                    shopTab = Console.ReadLine();
                }

                //if (shopTab == "Lucky Box")
                //{

                //}
            }
        }
    }
}
