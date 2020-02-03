namespace Game.Items
{
    public interface IGem
    {
        string Name { get; }

        int MaxCombineLevel { get; }

        int Count { get; }

        string ToString();
    }
}
