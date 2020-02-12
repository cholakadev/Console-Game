namespace Game.Items
{
    using System.Collections;
    using System.Collections.Generic;
    class GemsCollection : IEnumerable<Gem>
    {
        public GemsCollection()
        {
            this.Gems = new List<Gem>();
        }

        public List<Gem> Gems { get; set; }

        public void AddGems()
        {
            this.Gems.Add(new Gem("Small Ruby", 1));
            this.Gems.Add(new Gem("Medium Ruby", 3));
            this.Gems.Add(new Gem("Large Ruby", 5));

            this.Gems.Add(new Gem("Small Emerald", 1));
            this.Gems.Add(new Gem("Medium Emerald", 3));
            this.Gems.Add(new Gem("Large Emerald", 5));
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
