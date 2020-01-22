namespace Game.Core
{
    using System;
    using System.Linq;
    using Game.Characters;
    using Game.Items;
    using In_GameShop;
    using Game.InGameShop.Gems;

    public sealed class StartGame
    {
        public void Start(Player player, Monster monster, PlayerData playerData)
        {
            GameBody(player, monster, playerData);
        }

        private void GameBody(Player player, Monster monster, PlayerData playerData)
        {
            LoadGears();

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
                    CheckFightResult(player, monster);
                    player.DefaultValues(player, monster);
                }

                if (playerStats)
                {
                    player.PlayerStats(playerData);
                }

                if (inGameShop)
                {
                    GameShop();
                }

                Console.WriteLine();

                inputCommand = Console.ReadLine().Split().ToArray();
            }
        }

        public void CheckFightResult(Player player, Monster monster)
        {
            while (true)
            {
                player.FightEngine(player, monster);
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
            player.LoseExperiance();
            Console.WriteLine(player.Damage);
            Console.WriteLine(player.DamageAbsorb);
        }

        private void IfMonsterDie(Player player, Monster monster)
        {
            Console.WriteLine($"{player.Name} has slain {monster.Name} and left with {player.Health} health!");
            player.EarnExperience();
            player.DropSilver();
            Console.WriteLine(player.Damage);
            Console.WriteLine(player.DamageAbsorb);
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

        private void GameShop()
        {
            Console.WriteLine($"Our in-game shop disposes with pets, gems and lucky box sections.");
            string shopTab = Console.ReadLine();
            PetTab petShop = new PetTab();
            GemTab gemShop = new GemTab();
            //LuckyBox luckyBoxShop = new LuckyBox();

            Shop(shopTab, petShop, gemShop);
        }

        private void LoadGears()
        {
            ItemManager items = new ItemManager();
            items.LoadItems();
        }
    }
}
