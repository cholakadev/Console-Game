namespace Game.Characters.Responsible_For_Player
{
    public class DamageIncrease
    {
        public void IncreaseDamage(Player player)
        {
            if (player.Level <= 2)
            {
                player.Damage = 9;
            }

            else if (player.Level > 2 && player.Level <= 4)
            {
                player.Damage = 10;
            }

            else if (player.Level > 4 && player.Level <= 6)
            {
                player.Damage = 12;
            }

            else
            {
                player.Damage = 15;
            }
        }
    }
}
