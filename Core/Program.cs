namespace Game.Core
{
    using System;
    using Game.Characters;
    using Game.Items;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Choose player name: ");
            Player pl = new Player(Console.ReadLine());
            Monster monster = new Monster();

            ItemsList collection = new ItemsList(); // For refactoring. 

            Engine Game = new Engine();
            Game.Start(pl, monster, collection);
        }
    }
}
