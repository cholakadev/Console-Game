namespace Game
{
    using System.Collections;
    using System.Collections.Generic;
    public class PlayerData : IEnumerable<Player>
    {
        public PlayerData()
        {
            this.Players = new List<Player>();
        }

        public List<Player> Players { get; set; }
        public void Add(Player pl)
        {
            this.Players.Add(pl);
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
