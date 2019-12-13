namespace Game
{
    public class ItemManager
    {
        public void LoadItems()
        {
            ItemsList collection = new ItemsList();

            AddWeapons(collection);
            AddGears(collection);
            AddGems(collection);

            //foreach (var weapon in collection)
            //{
            //    System.Console.WriteLine($"{weapon.Name} - {weapon.Parameter}");
            //}
        }

        private void AddWeapons(ItemsList collection)
        {
            collection.Add(new Weapon("Bronze Sword", 5));
            collection.Add(new Weapon("Silver Sword", 7));
            collection.Add(new Weapon("Golden Sword", 9));
        }

        private void AddGears(ItemsList collection)
        {
            collection.Add(new Gear("Bronze Cuirass", 2));
            collection.Add(new Gear("Silver Cuirass", 3));
            collection.Add(new Gear("Golden Cuirass", 4));

            collection.Add(new Gear("Bronze Boots", 2));
            collection.Add(new Gear("Bronze Boots", 3));
            collection.Add(new Gear("Bronze Boots", 4));

            collection.Add(new Gear("Bronze Armguard", 2));
            collection.Add(new Gear("Bronze Armguard", 3));
            collection.Add(new Gear("Bronze Armguard", 4));
        }

        private void AddGems(ItemsList collection)
        {
            collection.Add(new Gem("Small Ruby", 1));
            collection.Add(new Gem("Medium Ruby", 3));
            collection.Add(new Gem("Large Ruby", 5));

            collection.Add(new Gem("Small Emerald", 1));
            collection.Add(new Gem("Medium Emerald", 3));
            collection.Add(new Gem("Large Emerald", 5));
        }
    }
}
