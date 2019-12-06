using System;
namespace Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Load gears
            Weapon wpn = new Weapon();
            wpn.AddWeapons();

            Player pl = new Player(Console.ReadLine());
            Monster monster = new Monster();

            PlayerData playerData = new PlayerData();
            playerData.Add(pl);

            StartGame Game = new StartGame();
            Game.Start(pl, monster, playerData);
        }
    }
}
