namespace Game.Items
{
    class GearEquip
    {
        public interface IGearEquippable
        {
            int Damage { get; }
            int Health { get; }
        }
    }
}
