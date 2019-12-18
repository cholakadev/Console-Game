namespace Game.InGameShop.Gems
{
    using Game.In_GameShop;
    using System;

    public class Gem : ShopItem
    {
        public Gem()
        {
        }

        public Gem(string name, double price, int maxCombineLevel)
            : base(name, price)
        {
            this.MaxCombineLevel = maxCombineLevel;
        }

        public int MaxCombineLevel { get; set; }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}" +
                $"Max combine level: {this.MaxCombineLevel}{Environment.NewLine}" +
                $"Price: {this.Price}{Environment.NewLine}";
        }
    }
}
