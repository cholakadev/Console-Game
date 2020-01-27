namespace Game.Items.Gems
{
    public class Gem : Item
    {
        public Gem(string name, int maxCombineLevel, int amount) : base(name)
        {
            this.MaxCombineLevel = maxCombineLevel;
            this.Amount = amount;
        }

        public Gem(string name) : base(name)
        {

        }

        public int MaxCombineLevel { get; private set; }

        public int Amount { get; set; }

        public override string ToString()
        {
            return $"{this.Name}, Max combine level: {this.MaxCombineLevel}";
        }
    }
}