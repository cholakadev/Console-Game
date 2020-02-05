namespace Game.Characters.Contracts
{
    using Game.Items;
    public interface IEquippable
    {
        Item Weapon { get; }
        Item Cuirass { get; }
        Item Boots { get; }
        Item Armguard { get; }
    }
}
