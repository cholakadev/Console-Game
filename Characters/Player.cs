namespace Game.Characters
{
    using System;
    using System.Linq;
    using System.Text;
    using Game.Items;
    using Game.Methods;

    public class Player : Character
    {
        private int level;

        public Player(string name) : base(name, 0, 30)
        {
            this.Experience = 0;
            this.Level = 1;
            this.DamageAbsorb = 0;
            this.Gold = 0;
            this.Silver = 0;
            this.Weapon = new Weapon();
            this.Armor = new Armor();
            this.Boots = new Boots();
            this.Armguard = new Armguard();
        }

        public int Experience { get; set; }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
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
        public Weapon Weapon { get; private set; }
        public Armor Armor { get; private set; }
        public Boots Boots { get; private set; }
        public Armguard Armguard { get; private set; }

        public void CollectCurrency()
        {
            int result = UtilityMethods.Random(55, 85);
            this.Silver += result;

            if (this.Silver >= 100)
            {
                this.Silver -= 100;
                this.Gold++;
            }
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

        public void DropEquipment()
        {
            GearCollection gears = new GearCollection();
            gears.AddGears();

            var rnd = new Random();
            int maxIndex = gears.Gears.Count;
            Gear item = gears.Gears[rnd.Next(maxIndex)];

            Console.WriteLine($"You have earned {item.Name}. Congratulations!");


            if (item.Name.Contains("Sword"))
            {

                Weapon newWeapon = (Weapon)item;

                if (this.Weapon.CompareTo(newWeapon) < 0)
                {
                    this.Weapon = newWeapon;
                }
            }

            else if (item.Name.Contains("Cuirass"))
            {

                Armor newArmor = (Armor)item;

                if (this.Armor.CompareTo(newArmor) < 0)
                {
                    this.Armor = newArmor;
                }
            }

            else if (item.Name.Contains("Boots"))
            {

                Boots newBoots = (Boots)item;

                if (this.Boots.CompareTo(newBoots) < 0)
                {
                    this.Boots = newBoots;
                }
            }

            if (item.Name.Contains("Armguard"))
            {

                Armguard newArmguard = (Armguard)item;

                if (this.Armguard.CompareTo(newArmguard) < 0)
                {
                    this.Armguard = newArmguard;
                }
            }

            IncreaseStats();

            // Add other junk items in player inventory.
        }

        //public void DropGems(GemsCollection gemsCollection)
        //{
        //    var rnd = new Random();
        //    int maxIndex = gemsCollection.Gems.Count();
        //    Gem gem = gemsCollection.Gems[rnd.Next(maxIndex)];

        //    Console.WriteLine($"You have earned {gem.Name}. Congratulations!");

        //    gem.Count++;

        //    foreach (var item in gemsCollection.Gems) // Use in another method which will be called for player stats
        //    {
        //        Console.WriteLine($"{item.Name}, Max combine level: {item.MaxCombineLevel}, {item.Count} pcs.");
        //    }
        //}

        private void IncreaseStats()
        {
            this.Damage += this.Weapon.Damage;

            this.Health +=
                this.Armor.Health
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
            sb.AppendLine($"{this.Armor}");
            sb.AppendLine($"{this.Boots}");
            sb.AppendLine($"{this.Armguard}");

            sb.AppendLine($"Total damage: {this.Damage}");
            sb.AppendLine($"Total health: {this.Health}");

            return sb.ToString().TrimEnd();
        }
    }
}
