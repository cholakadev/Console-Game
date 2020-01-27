namespace Game.Core
{
    using System;
    using Game.Characters;
    using Game.Items;
    using Game.Items.Gears;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Choose player name: ");
            Player pl = new Player(Console.ReadLine());
            Monster monster = new Monster();

            Engine Game = new Engine();
            ItemsList collection = new ItemsList();
            ItemManager manager = new ItemManager();

            manager.LoadItems(collection);
            Game.Start(pl, monster, collection);
        }
    }
}
