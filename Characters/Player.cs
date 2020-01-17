namespace Game.Characters
{
    using System;
    using System.Text;
    using Game.Items;
    using Game.Methods;
    public class Player : Character
    {
        private int level;
        private int damageAbsorb;
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
                if (value == 4)
                {
                    throw new ArgumentException($"{this.Name} has reached max level!");
                }

                this.level = value;
            }
        }
        public int DamageAbsorb
        {
            get
            {
                return this.damageAbsorb;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Damage Absorb can't be less than 0.", "Player Damage Absorb");
                }

                this.damageAbsorb = value;
            }
        }
        public int Silver { get; set; }
        public double Gold { get; set; }

        public void LoseExperiance(Player player, int exp)
        {
            if (player.Experience <= 10)
            {
                Console.WriteLine($"Your experience is 0%. Try harder!");
                player.Experience = 0;
            }

            else if (player.Experience > 10)
            {
                Console.WriteLine($"You lost {exp}% experience!");
                player.Experience -= exp;
            }
        }

        public void LevelUp(Player player)
        {
            if (player.Experience >= 100)
            {
                player.Level++;
                player.Experience = player.Experience - 100;
                if (player.Level < 4)
                {
                    Console.WriteLine($"{player.Name} has reached level {player.Level}");
                }
            }
        }

        public void DropSilver(Player player)
        {
            int result = UtilityMethods.Random(55, 85);
            player.Silver += result;

            if (player.Silver >= 100)
            {
                player.Silver -= 100;
                player.Gold++;
            }
        }

        public void PlayerStats(Player player, PlayerData playerData)
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
        }

        public void EarnExperience(Player player)
        {
            int exp = 0;

            if (player.Level < 3)
            {
                exp = 60;
                //player.Damage = UtilityMethods.Random(5, 12);
                player.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            else if (player.Level >= 3 && player.Level < 6)
            {
                exp = 30;
                //player.Damage = UtilityMethods.Random(6, 14);
                player.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            else if (player.Level >= 6)
            {
                exp = 15;
                //player.Damage = UtilityMethods.Random(8, 15);
                player.Experience += exp;
                Console.WriteLine($"{exp}% experience earned!");
            }

            player.LevelUp(player);
        }

        //public Item DropEquipment(Player player)
        //{
        //    Algorithm to drop random equipment each time.
        //}
    }
}
