namespace Game.Items.Weapons
{
    using System;
    public class Weapon : Item, IComparable<Weapon>
    {
        public Weapon(string name, int health, int damage) : base(name, health, damage)
        {

        }

        public Weapon(string name) : base(name)
        {

        }

        public int CompareTo(Weapon other)
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