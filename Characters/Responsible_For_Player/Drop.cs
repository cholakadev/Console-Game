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
                    ChangeEquipment(newWeapon, player);
                }
            }

            else if (item.Name.Contains("Cuirass"))
            {
                Armor newArmor = (Armor)item;

                if (player.Armor.CompareTo(newArmor) < 0)
                {
                    ChangeEquipment(newArmor, player);
                }
            }

            else if (item.Name.Contains("Boots"))
            {
                Boots newBoots = (Boots)item;

                if (player.Boots.CompareTo(newBoots) < 0)
                {
                    ChangeEquipment(newBoots, player);
                }
            }

            else if (item.Name.Contains("Armguard"))
            {
                Armguard newArmguard = (Armguard)item;

                if (player.Armguard.CompareTo(newArmguard) < 0)
                {
                    ChangeEquipment(newArmguard, player);
                }
            }

            IncreaseStats(player);
        }

        public void ChangeEquipment(Gear newGear, Player player)
        {
            if (newGear is Armor)
            {
                player.Armor = (Armor)newGear;
            }

            else if (newGear is Boots)
            {
                player.Boots = (Boots)newGear;
            }

            else if (newGear is Armguard)
            {
                player.Armguard = (Armguard)newGear;
            }

            else if (newGear is Weapon)
            {
                player.Weapon = (Weapon)newGear;
            }
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
