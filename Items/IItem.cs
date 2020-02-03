namespace Game.Items
{
    public interface IItem
    {
        string Name { get; }

        int Health { get; }

        int Damage { get; }
    }
}
