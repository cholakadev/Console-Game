using System;
using static Game.Items.GearEquip;

namespace Game.Items
{
    public class Item : IGearEquippable, IComparable<Item>
    {
        private int health;
        private int damage;
        public Item(string name, int health, int damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public Item(string name)
        {

        }
        public string Name { get; private set; }


        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Health can't be less then 0.");
                }

                this.health = value;
            }
        }


        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Weapon damage", "Weapon damage can't be less than or equals to 0.");
                }

                this.damage = value;
            }
        }

        public int CompareTo(Item other)
        {
            if (this.Damage > other.Damage)
            {
                return 1;
            }

            else if (this.Damage < other.Damage)
            {
                return -1;
            }

            else
            {
                return 0;
            }
        }
    }
}
