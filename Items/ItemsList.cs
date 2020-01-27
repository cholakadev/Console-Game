namespace Game.Items
{
    using Game.Items.Gems;
    using System.Collections.Generic;

    public class ItemsList
    {
        public ItemsList()
        {
            this.ItemsCollection = new List<Item>();
            this.GemsCollection = new List<Gem>();
        }

        public List<Item> ItemsCollection { get; set; }
        public List<Gem> GemsCollection{ get; set; }

        public IEnumerator<Item> GetEnumerator()
        {
            foreach (var item in ItemsCollection)
            {
                yield return item;
            }
        }
    }
}