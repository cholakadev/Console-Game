using Game.Items;

namespace Game.Characters
{
    public interface IPlayer
    {
        string Name { get; }

        int Experience { get; }

        int Level { get; }

        int DamageAbsorb { get; }

        double Gold { get; }

        Item Weapon { get; }

        Item Cuirass { get; }

        Item Boots { get; }

        Item Armguard { get; }

        string ToString();
    }
}
