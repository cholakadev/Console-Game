namespace Game.Items
{
    public interface IGear
    {
        string Name { get; }

        int Health { get; }

        int Damage { get; }

        string ToString();
    }
}
