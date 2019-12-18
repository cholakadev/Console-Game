using System;

namespace Game
{
    public class Gem : Item
    {
        public Gem(string name, int maxCombineLevel) : base(name)
        {
            this.MaxComvineLevel = maxCombineLevel;
        }

        public int MaxComvineLevel { get; set; }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}" +
                $"Max combine level: {this.MaxComvineLevel}{Environment.NewLine}";
        }
    }
}
