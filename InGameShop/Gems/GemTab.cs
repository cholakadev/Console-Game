namespace Game.InGameShop.Gems
{
    using Game.In_GameShop;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class GemTab : IEnumerable<ShopItem>
    {
        private List<ShopItem> gemShop;

        public GemTab()
        {
            this.gemShop = new List<ShopItem>();
        }

        public void Add(ShopItem gem)
        {
            gemShop.Add(gem);
        }

        public void AddGems(GemTab inGameShopGemTab)
        {
            inGameShopGemTab.Add(new Gem("Small Ruby", 0.25, 1));
            inGameShopGemTab.Add(new Gem("Medium Ruby", 0.50 , 3));
            inGameShopGemTab.Add(new Gem("Large Ruby", 1, 5));

            inGameShopGemTab.Add(new Gem("Small Emerald", 0.25, 1));
            inGameShopGemTab.Add(new Gem("Medium Emerald", 0.50, 3));
            inGameShopGemTab.Add(new Gem("Large Emerald", 1, 5));
        }

        public void PrintGemTab(GemTab collection)
        {
            foreach (var gem in collection)
            {
                Console.WriteLine(gem);
            }
        }

        public IEnumerator<ShopItem> GetEnumerator()
        {
            foreach (var gem in gemShop)
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
