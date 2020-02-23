namespace Game.Characters
{
    public interface IEnemy
    {
        string Name { get; }

        int Damage { get; }

        int Health { get; }
    }
}
