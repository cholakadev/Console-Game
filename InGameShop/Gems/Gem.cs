namespace Game.InGameShop.Gems
{
    using Game.In_GameShop;
    using System.Text;

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

        public int MaxCombineLevel { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name}");
            sb.AppendLine($"Max combine level: {this.MaxCombineLevel}");
            sb.AppendLine($"Price: {this.Price}");

            return sb.ToString();
        }
    }
}
