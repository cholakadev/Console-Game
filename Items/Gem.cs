namespace Game.Items.Gems
{
    public class Gem
    {
        public Gem(string name, int maxCombineLevel, int count)
        {
            this.Name = name;
            this.MaxCombineLevel = maxCombineLevel;
            this.Count = count;
        }

        public Gem()
        {

        }

        public string Name { get; set; }

        public int MaxCombineLevel { get; private set; }

        public int Count { get; set; }

        public override string ToString()
        {
            return $"{this.Name}, Max combine level: {this.MaxCombineLevel}";
        }
    }
}