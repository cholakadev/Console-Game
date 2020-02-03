namespace Game.Items
{
    using Game.Items.Gems;
    using System.Collections;
    using System.Collections.Generic;
    public class GemsCollection : IEnumerable<Gem>, IGemCollection
    {
        public List<Gem> Gems { get; private set; }

        public GemsCollection()
        {
            this.Gems = new List<Gem>();
        }

        public void InitializeGemCollection() // Add other junk items to drop.
        {
            Gems.Add(new Gem("Small Ruby", 1, 0));
            Gems.Add(new Gem("Medium Ruby", 3, 0));
            Gems.Add(new Gem("Large Ruby", 5, 0));

            Gems.Add(new Gem("Small Emerald", 1, 0));
            Gems.Add(new Gem("Medium Emerald", 3, 0));
            Gems.Add(new Gem("Large Emerald", 5, 0));
        }

        public IEnumerator<Gem> GetEnumerator()
        {
            foreach (var gem in Gems)
            {
                yield return gem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
