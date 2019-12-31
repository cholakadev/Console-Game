namespace Game.Items
{
    using System.Collections;
    using System.Collections.Generic;

    class ItemsList : IEnumerable<Item>
    {
        private List<Item> itemsList;

        public ItemsList()
        {
            this.itemsList = new List<Item>();
        }

        public void Add(Item item)
        {
            itemsList.Add(item);
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
