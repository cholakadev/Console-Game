namespace Game.Methods
{
    using System;
    using System.Text;
    public sealed class UtilityMethods
    {
        public static int Random(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }

        public static string OverrideToStringSpeedImprovement(string name, int secondaryParameter, string statName)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{name}");
            sb.AppendLine($"{statName}: {secondaryParameter}");

            return sb.ToString();
        }
    }
}
