namespace Game.Items
{
    using System;
    public class Boots : Gear, IComparable<Boots>
    {
        public Boots(string name, int health, int damageAbsorb) : base(name)
        {
            this.Health = health;
            this.DamageAbsorb = damageAbsorb;
        }

        public Boots()
        {

        }

        public int Health { get; set; }

        public int DamageAbsorb { get; set; }

        public override string ToString()
        {
            return $"{this.Name} | Health: {this.Health} | Damage Absorb: {this.DamageAbsorb}";
        }


        public int CompareTo(Boots other)
        {
            if (this.Health > other.Health)
            {
                return 1;
            }

            else if (this.Health < other.Health)
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