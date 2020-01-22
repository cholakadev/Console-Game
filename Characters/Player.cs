namespace Game.Characters
{
    using System;
    using System.Linq;
    using System.Text;
    using Game.Items;
    using Game.Methods;
    public class Player : Character
    {
        private const int ExperienceToLose = 10;
        private int level;
        public Player(string name) : base(name, 0, 30)
        {
            this.Experience = 0;
            this.Level = 1;
            this.DamageAbsorb = 0;
            this.Gold = 0;
            this.Silver = 0;
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

        public void LevelUp()
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

        public void PlayerStats(PlayerData playerData)
        {
            foreach (var character in playerData)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Level: {character.Level}");
                sb.AppendLine($"Experience: {character.Experience}");
                sb.AppendLine($"Health: {character.Health}");
                sb.AppendLine($"Gold: {character.Gold}.{character.Silver}");

                //sb.AppendLine($"{} sword (damage +{})");
                //sb.AppendLine($"{} armor (damage absorb +{}, health +{})");
                //sb.AppendLine($"{} boots (damage absorb +{}, health +{})");
                //sb.AppendLine($"{} armguard (damage absorb +{}, health +{})");

                string result = sb.ToString().TrimEnd();
                Console.WriteLine(result);
            }
        } // Show current equipments in player stats command.

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
            ItemManager manager = new ItemManager();
            manager.LoadItems(collection);

            var rnd = new Random();
            int maxIndex = collection.ItemsCollection.Count();
            var item = collection.ItemsCollection[rnd.Next(maxIndex)];

            Console.WriteLine(item.Name);

            if (item.Name.Contains("Armguard"))
            {

            }

            else if (item.Name.Contains("Boots"))
            {

            }

            else if (item.Name.Contains("Armor"))
            {

            }

            else if (item.Name.Contains("Sword"))
            {

            }
        }

        //public Item DropEquipment(Player player)
        //{
        //    Algorithm to drop random equipment each time.
        //}
    }
}
