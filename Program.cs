using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Load gears
            Weapon wpn = new Weapon();
            wpn.AddWeapons();

            // ----------------------------

            PlayerData playerData = new PlayerData();
            List<string> plData = Console.ReadLine()
                    .Split()
                    .ToList();

            var plName = plData[0];
            Player pl = new Player(plName);
            playerData.Add(pl);

            Monster monster = new Monster();

            StartGame start = new StartGame();
            start.Start(pl, monster, playerData);
        }
    }
}
