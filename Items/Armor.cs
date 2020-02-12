namespace Game.Items
{
    using System;
    public class Armor : Gear, IComparable<Armor>
    {
        public Armor(string name, int health, int damageAbsorb) : base(name)
        {
            this.Health = health;
            this.DamageAbsorb = damageAbsorb;
        }

        public Armor()
        {

        }

        public int Health { get; set; }

        public int DamageAbsorb { get; set; }

        public override string ToString()
        {
            return $"{this.Name} | Health: {this.Health} | Damage Absorb: {this.DamageAbsorb}";
        }

        public int CompareTo(Armor other)
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