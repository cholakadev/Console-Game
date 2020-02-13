namespace Game.Characters
{
    using System;
    using System.Text;
    using Game.Characters.Responsible_For_Player;
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
        public int DamageAbsorb { get; set; }
        public int Silver { get; private set; }
        public double Gold { get; private set; }
        public Weapon Weapon { get; private set; }
        public Armor Armor { get; private set; }
        public Boots Boots { get; private set; }
        public Armguard Armguard { get; private set; }

        public void ChangeEquipment(Gear newGear)
        {
            if (newGear is Armor)
            {
                this.Armor = (Armor)newGear;
            }

            else if (newGear is Boots)
            {
                this.Boots = (Boots)newGear;
            }

            else if (newGear is Armguard)
            {
                this.Armguard = (Armguard)newGear;
            }

            else if (newGear is Weapon)
            {
                this.Weapon = (Weapon)newGear;
            }
        }

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

        public void IncreasePlayerStats(Player player)
        {
            DamageIncrease damageIncrease = new DamageIncrease();

            damageIncrease.IncreaseDamage(player);

            AbsorbIncrease absorbIncrease = new AbsorbIncrease();

            absorbIncrease.IncreaseDamageAbsorb(player);
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