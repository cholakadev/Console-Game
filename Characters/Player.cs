namespace Game.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Game.Items.Gems;
    using Game.Items;
    using Game.Items.Gears;
    using Game.Items.Weapons;
    using Game.Methods;
    public class Player : Character
    {
        private const int ExperienceToLose = 10;
        private int level;

        private Gem smallRuby;
        private Gem mediumRuby;
        private Gem largeRuby;
        private Gem smallEmerald;
        private Gem mediumEmerald;
        private Gem largeEmerald;

        private Dictionary<Item, int> gems;
        public Player(string name) : base(name, 0, 30)
        {
            this.Experience = 0;
            this.Level = 1;
            this.DamageAbsorb = 0;
            this.Gold = 0;
            this.Silver = 0;
            this.Weapon = new Weapon("None");
            this.Cuirass = new Gear("None");
            this.Boots = new Gear("None");
            this.Armguard = new Gear("None");
            this.smallRuby = new Gem("");
            this.mediumRuby = new Gem("");
            this.largeRuby = new Gem("");
            this.smallEmerald = new Gem("");
            this.mediumEmerald = new Gem("");
            this.largeEmerald = new Gem("");
            this.gems = new Dictionary<Item, int>();
        }

        public int Experience { get; private set; }
        public int Level
        {
            get
            {
                return this.level;
            }
            private set
            {
                if (value == 8)
                {
                    throw new ArgumentException($"{this.Name} has reached max level!");
                }

                this.level = value;
            }
        }
        public int DamageAbsorb { get; private set; }
        public int Silver { get; private set; }
        public double Gold { get; private set; }
        public Item Weapon { get; private set; }
        public Item Cuirass { get; private set; }
        public Item Boots { get; private set; }
        public Item Armguard { get; private set; }

        public void LoseExperiance()
        {
            if (this.Experience <= 10)
            {
                Console.WriteLine($"Your experience is 0%. Try harder!");
                this.Experience = 0;
            }

            else if (this.Experience > 10)
            {
                Console.WriteLine($"You lost {ExperienceToLose}% experience!");
                this.Experience -= ExperienceToLose;
            }
        }

        private void LevelUp()
        {
            if (this.Experience >= 100)
            {
                this.Level++;
                this.Experience = this.Experience - 100;
                if (this.Level < 8)
                {
                    Console.WriteLine($"{this.Name} has reached level {this.Level}");
                }
            }
        }

        public void DropSilver()
        {
            int result = UtilityMethods.Random(55, 85);
            this.Silver += result;

            if (this.Silver >= 100)
            {
                this.Silver -= 100;
                this.Gold++;
            }
        }

        public void EarnExperience()
        {
            int exp = 0;

            if (this.Level < 3)
            {
                exp = 60;
                this.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            else if (this.Level >= 3 && this.Level < 6)
            {
                exp = 30;
                this.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            else if (this.Level >= 6)
            {
                exp = 15;
                this.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            LevelUp();
        }

        public void IncreaseStats(Player player)
        {
            IncreaseDamage(player);
            IncreaseDamageAbsorb();
        }

        private void IncreaseDamageAbsorb()
        {
            if (this.Level <= 2)
            {
                this.DamageAbsorb = UtilityMethods.Random(1, 4);
            }

            else if (this.Level > 2 && this.Level <= 4)
            {
                this.DamageAbsorb = UtilityMethods.Random(2, 5);
            }

            else if (this.Level > 4 && this.Level <= 6)
            {
                this.DamageAbsorb = UtilityMethods.Random(3, 6);
            }

            else
            {
                this.DamageAbsorb = UtilityMethods.Random(4, 7);
            }
        }

        public void DropEquipment(ItemsList collection)
        {
            var rnd = new Random();
            int maxIndex = collection.ItemsCollection.Count();
            Item item = collection.ItemsCollection[rnd.Next(maxIndex)];

            Console.WriteLine($"You have earned {item.Name}. Congratulations!");


            if (item.Name.Contains("Armguard"))
            {
                if (this.Armguard.CompareTo(item) < 0)
                {
                    this.Armguard = item;
                }
            }

            else if (item.Name.Contains("Boots"))
            {
                if (this.Boots.CompareTo(item) < 0)
                {
                    this.Boots = item;
                }
            }

            else if (item.Name.Contains("Cuirass"))
            {
                if (this.Cuirass.CompareTo(item) < 0)
                {
                    this.Cuirass = item;
                }
            }

            else if (item.Name.Contains("Sword"))
            {
                if (this.Weapon.CompareTo(item) < 0)
                {
                    this.Weapon = item;
                }
            }

            IncreaseStats();

            // Add other junk items in player inventory.
        }

        public void DropGems(ItemsList gemsCollection)
        {
            var rnd = new Random();
            int maxIndex = gemsCollection.GemsCollection.Count();
            Gem gem = gemsCollection.GemsCollection[rnd.Next(maxIndex)];

            Console.WriteLine($"You have earned {gem.Name}. Congratulations!");

            if (gem.Name.Contains("Small"))
            {
                if (gem.Name.Contains("Ruby"))
                {
                    this.gems[gem]++;
                }

                else if (gem.Name.Contains("Emerald"))
                {
                    this.gems[gem]++;
                }
            }

            else if (gem.Name.Contains("Medium"))
            {
                if (gem.Name.Contains("Ruby"))
                {
                    this.gems[gem]++;
                }

                else if (gem.Name.Contains("Emerald"))
                {
                    this.gems[gem]++;
                }
            }

            else if (gem.Name.Contains("Lagre"))
            {
                if (gem.Name.Contains("Ruby"))
                {
                    this.gems[gem]++;
                }

                else if (gem.Name.Contains("Emerald"))
                {
                    this.gems[gem]++;
                }
            }
        }

        private void InitializeGemsDictionary()
        {
            this.gems.Add(new Gem("Small Ruby", 1), 0);
            this.gems.Add(new Gem("Medium Ruby", 3), 0);
            this.gems.Add(new Gem("Large Ruby", 5), 0);

            this.gems.Add(new Gem("Small Emerald", 1), 0);
            this.gems.Add(new Gem("Medium Emerald", 1), 0);
            this.gems.Add(new Gem("Large Emerald", 1), 0);
        }

        private void IncreaseStats()
        {
            this.Damage += this.Weapon.Damage
                + this.Cuirass.Damage
                + this.Boots.Damage
                + this.Armguard.Damage;

            this.Health += this.Weapon.Health
                + this.Cuirass.Health
                + this.Boots.Health
                + this.Armguard.Health;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Level: {this.Level}");
            sb.AppendLine($"Experience: {this.Experience}");
            sb.AppendLine($"Health: {this.Health}");
            sb.AppendLine($"Gold: {this.Gold}.{this.Silver}");

            sb.AppendLine($"{this.Weapon}");
            sb.AppendLine($"{this.Cuirass}");
            sb.AppendLine($"{this.Boots}");
            sb.AppendLine($"{this.Armguard}");

            sb.AppendLine($"Total damage: {this.Damage}");
            sb.AppendLine($"Total health: {this.Health}");

            sb.AppendLine($"Gems: {string.Join(", ", gems)}");

            return sb.ToString().TrimEnd();
        }
    }
}
