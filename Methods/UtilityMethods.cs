namespace Game.Methods
{
    using System;
    using Game.Items;
    public sealed class UtilityMethods
    {
        public static int Random(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }
    }
}
