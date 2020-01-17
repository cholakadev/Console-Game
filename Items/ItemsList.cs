namespace Game.Items
{
    using System.Collections;
    using System.Collections.Generic;

    public sealed class ItemsList : IEnumerable<Item>
    {
        private List<Item> itemsList;

        public ItemsList()
        {
            this.itemsList = new List<Item>();
        }

        public int Count { get; set; }

        public void Add(Item item)
        {
            itemsList.Add(item);
            this.Count++;
        }

        public IEnumerator<Item> GetEnumerator()
        {
            foreach (var item in itemsList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
