namespace Game
{
    using System;
    using System.Text;
    public class PlayerManager
    {
        public static void PlayerStats(Player pl, PlayerData playerData)
        {
            foreach (var player in playerData)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Level: {player.Level}");
                sb.AppendLine($"Experience: {player.Experience}");
                sb.AppendLine($"Health: {player.Health}");
                sb.AppendLine($"Gold: {player.Gold}.{player.Silver}");

                //sb.AppendLine($"{} sword (damage +{})");
                //sb.AppendLine($"{} armor (damage absorb +{}, health +{})");
                //sb.AppendLine($"{} boots (damage absorb +{}, health +{})");
                //sb.AppendLine($"{} armguard (damage absorb +{}, health +{})");

                string result = sb.ToString().TrimEnd();
                Console.WriteLine(result);
            }
        }
    }
}
