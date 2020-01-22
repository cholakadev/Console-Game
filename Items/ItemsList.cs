namespace Game.Items
{
    using System.Collections.Generic;

    public class ItemsList
    {
        public ItemsList()
        {
            this.ItemsCollection = new List<Item>();
        }

        public List<Item> ItemsCollection { get; set; }

        public IEnumerator<Item> GetEnumerator()
        {
            foreach (var item in ItemsCollection)
            {
                yield return item;
            }
        }
    }
}
