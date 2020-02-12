namespace Game.Items
{
    using Game.Characters;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PlayerInventory
    {
        public PlayerInventory()
        {
            this.Gems = new Dictionary<Gem, int>();
        }

        public Dictionary<Gem, int> Gems { get; set; }

        public void Drop()
        {
            GemsCollection gemsCollection = new GemsCollection();
            gemsCollection.AddGems();

            var rnd = new Random();
            int maxIndex = gemsCollection.Gems.Count;
            Gear item = gemsCollection.Gems[rnd.Next(maxIndex)];

            Console.WriteLine($"You have earned {item.Name}. Congratulations!");

            if (item.Name.Contains("Small"))
            {
                if (item.Name.Contains("Ruby"))
                {
                    Gem gem = (Gem)item;

                    if (!this.Gems.ContainsKey(gem))
                    {
                        Gems[gem] = 0;
                    }

                    Gems[gem]++;
                }

                else if (item.Name.Contains("Emerald"))
                {
                    Gem gem = (Gem)item;

                    if (!this.Gems.ContainsKey(gem))
                    {
                        Gems[gem] = 0;
                    }

                    Gems[gem]++;
                }
            }

            else if (item.Name.Contains("Medium"))
            {
                if (item.Name.Contains("Ruby"))
                {
                    Gem gem = (Gem)item;

                    if (!this.Gems.ContainsKey(gem))
                    {
                        Gems[gem] = 0;
                    }

                    Gems[gem]++;
                }

                else if (item.Name.Contains("Emerald"))
                {
                    Gem gem = (Gem)item;

                    if (!this.Gems.ContainsKey(gem))
                    {
                        Gems[gem] = 0;
                    }

                    Gems[gem]++;
                }
            }

            else if (item.Name.Contains("Large"))
            {
                if (item.Name.Contains("Ruby"))
                {
                    Gem gem = (Gem)item;

                    if (!this.Gems.ContainsKey(gem))
                    {
                        Gems[gem] = 0;
                    }

                    Gems[gem]++;
                }

                else if (item.Name.Contains("Emerald"))
                {
                    Gem gem = (Gem)item;

                    if (!this.Gems.ContainsKey(gem))
                    {
                        Gems[gem] = 0;
                    }

                    Gems[gem]++;
                }
            }
        }

        public string PrintInventory()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var gem in this.Gems)
            {
                sb.AppendLine($"{gem.Key.Name} - {gem.Value}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
