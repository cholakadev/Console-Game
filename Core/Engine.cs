namespace Game.Core
{
    using System;
    using System.Linq;
    using Game.Characters;
    using In_GameShop;
    using Game.InGameShop.Gems;
    using Game.Items;

    public sealed class Engine
    {
        public void Start(Player player, Monster monster)
        {
            GameBody(player, monster);
        }

        private void GameBody(Player player, Monster monster
            )
        {
            string[] inputCommand = Console.ReadLine().Split().ToArray();

            while (true)
            {
                string command = inputCommand[0];
                string action = inputCommand[1];

                bool fightMonster = command.ToLower() == "fight" && action.ToLower() == "monster";
                bool playerStats = command.ToLower() == "player" && action.ToLower() == "stats";
                bool inGameShop = command.ToLower() == "in-game" && action.ToLower() == "shop";
                bool inventory = command.ToLower() == "player" && action.ToLower() == "inventory";

                if (fightMonster)
                {
                    CheckFightResult(player, monster);
                    player.DefaultValues(player, monster);
                }

                if (playerStats)
                {
                    Console.WriteLine(player);
                }

                if (inGameShop)
                {
                    GameShop();
                }

                if (inventory)
                {
                    player.ShowInventory();
                }

                Console.WriteLine();

                inputCommand = Console.ReadLine().Split().ToArray();
            }
        }

        public void CheckFightResult(Player player, Monster monster)
        {
            while (true)
            {
                Battle battle = new Battle();
                battle.FightEngine(player, monster);
                player.IncreaseStats(player);

                if (player.Health < monster.Health && player.Health <= 0)
                {
                    IfPlayerDie(player, monster);
                    break;
                }

                else if (monster.Health < player.Health && monster.Health <= 0)
                {
                    IfMonsterDie(player, monster);
                    break;
                }
            }
        }

        private void IfPlayerDie(Player player, Monster monster)
        {
            Console.WriteLine($"{monster.Name} has slain {player.Name} and left with {monster.Health} health!");
            ExperienceProcess expProcess = new ExperienceProcess();
            expProcess.LoseExperience(player);
        }

        private void IfMonsterDie(Player player, Monster monster)
        {
            ExperienceProcess expProcess = new ExperienceProcess();

            Console.WriteLine($"{player.Name} has slain {monster.Name} and left with {player.Health} health!");
            expProcess.EarnExperience(player);

            player.CollectCurrency();

            player.DropEquipment();

            player.DropGem();
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
                    petShop.PrintPetTab(petShop);
                    shopTab = Console.ReadLine();
                }

                if (toGemsTab)
                {
                    gemShop.PrintGemTab(gemShop);
                    shopTab = Console.ReadLine();
                }

                //if (shopTab == "Lucky Box")
                //{

                //}
            }
        }

        private void GameShop()
        {
            Console.WriteLine($"Our in-game shop disposes with pets, gems and lucky box sections.");
            string shopTab = Console.ReadLine();
            PetTab petShop = new PetTab();
            GemTab gemShop = new GemTab();
            //LuckyBox luckyBoxShop = new LuckyBox();

            Shop(shopTab, petShop, gemShop);
        }
    }
}
