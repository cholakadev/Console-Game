namespace Game
{
    using System;
    public class LootManager
    {
        public static void DropSilver(Player pl)
        {
            Random random = new Random();

            int result = random.Next(55, 85);
            pl.Silver += result;

            if (pl.Silver >= 100)
            {
                pl.Silver -= 100;
                pl.Gold++;
            }
        }
    }
}
