namespace Game.Items.Gems
{
    using Game.Methods;
    using System;

    public class Gem : Item
    {
        public Gem(string name, int maxCombineLevel) : base(name)
        {
            this.MaxComvineLevel = maxCombineLevel;
        }

        public int MaxComvineLevel { get; set; }

        public override string ToString()
        {
            return UtilityMethods
                .OverrideToStringSpeedImprovement(this.Name, this.MaxComvineLevel, "Max combine level");
        }
    }
}
