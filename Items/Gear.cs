namespace Game.Items.Gears
{
    using System;

    public class Gear : Item, IComparable<Gear>, IGear
    {
        public Gear(string name, int health, int damage) : base(name, health, damage)
        {
        }

        public Gear(string name) : base(name)
        {
        }

        public int CompareTo(Gear other)
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

        public override string ToString()
        {
            return $"{this.Name}, Health: {this.Health}, Damage: {this.Damage}";
        }
    }
}