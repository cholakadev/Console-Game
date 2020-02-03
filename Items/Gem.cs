namespace Game.Items.Gems
{
    public class Gem : IGem
    {
        public Gem(string name, int maxCombineLevel, int count)
        {
            this.Name = name;
            this.MaxCombineLevel = maxCombineLevel;
            this.Count = count;
        }

        public string Name { get; private set; }

        public int MaxCombineLevel { get; private set; }

        public int Count { get; set; }

        public override string ToString()
        {
            return $"{this.Name}, Max combine level: {this.MaxCombineLevel}";
        }
    }
}