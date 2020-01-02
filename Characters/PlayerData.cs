namespace Game.Characters
{
    using System.Collections;
    using System.Collections.Generic;
    public sealed class PlayerData : IEnumerable<Player>
    {
        private List<Player> Players;
        public PlayerData()
        {
            this.Players = new List<Player>();
        }

        public void Add(Player player)
        {
            this.Players.Add(player);
        }

        public IEnumerator<Player> GetEnumerator()
        {
            foreach (var person in Players)
            {
                yield return person;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
