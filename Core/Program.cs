namespace Game.Core
{
    using System;
    using Game.Characters;
    using Game.InGameShop.Gems;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Choose player name: ");
            Player pl = new Player(Console.ReadLine());
            Monster monster = new Monster();

            PlayerData playerData = new PlayerData();
            playerData.Add(pl);

            StartGame Game = new StartGame();
            Game.Start(pl, monster, playerData);
        }
    }
}
