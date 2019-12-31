namespace Game.Methods
{
    using Game.Characters;
    public class LootManager
    {
        public static void DropSilver(Player pl)
        {
            int result = UtilityMethods.Random(55, 85);
            pl.Silver += result;

            if (pl.Silver >= 100)
            {
                pl.Silver -= 100;
                pl.Gold++;
            }
        }
    }
}
