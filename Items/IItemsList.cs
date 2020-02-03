namespace Game.Items
{
    using Game.Items.Gems;
    using System.Collections.Generic;
    public interface IItemsList
    {
        List<Item> ItemsCollection { get; }

        List<Gem> GemsCollection { get; }
    }
}
