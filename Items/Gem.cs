namespace Game.Items
{
    public class Gem : Gear
    {
        public Gem(string name, int maxCombineLevel) : base(name)
        {
            this.MaxCombineLevel = maxCombineLevel;
        }

        public int MaxCombineLevel { get; set; }
    }
}