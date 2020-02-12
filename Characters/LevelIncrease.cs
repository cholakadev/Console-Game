namespace Game.Characters
{
    using System;
    public class LevelIncrease
    {
        public void LevelUp(Player player)
        {
            if (player.Experience >= 100)
            {
                player.Level++;
                player.Experience = player.Experience - 100;
                if (player.Level < 8)
                {
                    Console.WriteLine($"{player.Name} has reached level {player.Level}");
                }
            }
        }
    }
}
