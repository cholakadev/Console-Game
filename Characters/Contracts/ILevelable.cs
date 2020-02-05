namespace Game.Characters.Contracts
{
    public interface ILevelable : IEarnExperience, ILoseExperience
    {
        int Level { get; }
    }
}
