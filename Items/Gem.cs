namespace Game.Items
{
    using System.Text;
    public class Gem : Gear
    {
        public Gem(string name, int maxCombineLevel) : base(name)
        {
            this.MaxCombineLevel = maxCombineLevel;
        }

        public int MaxCombineLevel { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine($"Max Combine Level: {this.MaxCombineLevel}");

            return sb.ToString().TrimEnd();
        }
    }
}
