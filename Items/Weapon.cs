namespace Game.Items
{
    using System;

    public class Weapon : Gear, IComparable<Weapon>
    {
        public Weapon(string name, int damage) : base(name)
        {

            this.Damage = damage;
        }

        public Weapon()
        {

        }

        public int Damage { get; set; }

        public override string ToString()
        {
            return $"{this.Name} | Damage: {this.Damage}";
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
    }
}