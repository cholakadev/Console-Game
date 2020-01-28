using Game.Items.Gems;
using System.Collections;
using System.Collections.Generic;

namespace Game.Items
{
    public class GemsCollection : IEnumerable<Gem>
    {
        public List<Gem> Gems { get; set; }

        public void InitializeGemCollection()
        {
            Gems.Add(new Gem("Small Ruby", 1, 0));  // Object reference not set to an instance of an object.
            Gems.Add(new Gem("Medium Ruby", 3, 0));
            Gems.Add(new Gem("Large Ruby", 5, 0));

            Gems.Add(new Gem("Small Emerald", 1, 0));
            Gems.Add(new Gem("Medium Emerald", 3, 0));
            Gems.Add(new Gem("Large Emerald", 5, 0));

            foreach (var gem in Gems)
            {
                System.Console.WriteLine($"{gem.Name} - {gem.MaxCombineLevel}");
            }
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
