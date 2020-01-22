namespace Game.Items
{
    using Game.Items.Weapons;
    using Game.Items.Gems;
    using Game.Items.Gears;
    using System;
    using System.Collections;
    using System.Linq;

    public sealed class ItemManager
    {
        public void LoadItems(ItemsList collection)
        {
            //ItemsList collection = new ItemsList();

            AddWeapons(collection);
            AddGears(collection);
            AddGems(collection);

            //foreach (var weapon in collection)
            //{
            //    System.Console.WriteLine(weapon);
            //}
        }

        private void AddWeapons(ItemsList collection)
        {
            collection.ItemsCollection.Add(new Weapon("Bronze Sword", 5));
            collection.ItemsCollection.Add(new Weapon("Silver Sword", 7));
            collection.ItemsCollection.Add(new Weapon("Golden Sword", 9));
        }

        private void AddGears(ItemsList collection)
        {
            collection.ItemsCollection.Add(new Gear("Bronze Cuirass", 10, 2));
            collection.ItemsCollection.Add(new Gear("Silver Cuirass", 20, 3));
            collection.ItemsCollection.Add(new Gear("Golden Cuirass", 30, 4));

            collection.ItemsCollection.Add(new Gear("Bronze Boots", 10, 2));
            collection.ItemsCollection.Add(new Gear("Silver Boots", 20, 3));
            collection.ItemsCollection.Add(new Gear("Golden Boots", 30, 4));

            collection.ItemsCollection.Add(new Gear("Bronze Armguard", 10, 2));
            collection.ItemsCollection.Add(new Gear("Silver Armguard", 20, 3));
            collection.ItemsCollection.Add(new Gear("Golden Armguard", 30, 4));
        }

        private void AddGems(ItemsList collection)
        {
            collection.ItemsCollection.Add(new Gem("Small Ruby", 1));
            collection.ItemsCollection.Add(new Gem("Medium Ruby", 3));
            collection.ItemsCollection.Add(new Gem("Large Ruby", 5));

            collection.ItemsCollection.Add(new Gem("Small Emerald", 1));
            collection.ItemsCollection.Add(new Gem("Medium Emerald", 3));
            collection.ItemsCollection.Add(new Gem("Large Emerald", 5));
        }

        public void DropRandomEquipment(ItemsList collection)
        {
            LoadItems(collection);

            var rnd = new Random();
            int maxIndex = collection.ItemsCollection.Count();
            var item = collection.ItemsCollection[rnd.Next(maxIndex)];

            Console.WriteLine(item.Name);
        }
    }
}
