namespace Game.Characters.Responsible_For_Player
{
    using Game.Methods;
    public class AbsorbIncrease
    {
        public void IncreaseDamageAbsorb(Player player)
        {
            if (player.Level <= 2)
            {
                player.DamageAbsorb = UtilityMethods.Random(1, 4);
            }

            else if (player.Level > 2 && player.Level <= 4)
            {
                player.DamageAbsorb = UtilityMethods.Random(2, 5);
            }

            else if (player.Level > 4 && player.Level <= 6)
            {
                player.DamageAbsorb = UtilityMethods.Random(3, 6);
            }

            else
            {
                player.DamageAbsorb = UtilityMethods.Random(4, 7);
            }
        }
    }
}
