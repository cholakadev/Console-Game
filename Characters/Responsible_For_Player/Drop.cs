namespace Game.Characters.Responsible_For_Player
{
    using Game.Items;
    using System;
    public class Drop
    {
        public void DropEquipment(Player player)
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

                if (player.Weapon.CompareTo(newWeapon) < 0)
                {
                    player.ChangeEquipment(newWeapon);
                }
            }

            else if (item.Name.Contains("Cuirass"))
            {
                Armor newArmor = (Armor)item;

                if (player.Armor.CompareTo(newArmor) < 0)
                {
                    player.ChangeEquipment(newArmor);
                }
            }

            else if (item.Name.Contains("Boots"))
            {
                Boots newBoots = (Boots)item;

                if (player.Boots.CompareTo(newBoots) < 0)
                {
                    player.ChangeEquipment(newBoots);
                }
            }

            else if (item.Name.Contains("Armguard"))
            {
                Armguard newArmguard = (Armguard)item;

                if (player.Armguard.CompareTo(newArmguard) < 0)
                {
                    player.ChangeEquipment(newArmguard);
                }
            }

            IncreaseStats(player);
        }

        private void IncreaseStats(Player player)
        {
            player.Damage += player.Weapon.Damage;

            player.Health +=
                player.Armor.Health
                + player.Boots.Health
                + player.Armguard.Health;
        }
    }
}
