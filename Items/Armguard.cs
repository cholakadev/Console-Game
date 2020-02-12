namespace Game.Items
{
    using System;

    public class Armguard : Gear, IComparable<Armguard>
    {
        public Armguard(string name, int health, int damageAbsorb) : base(name)
        {
            this.Health = health;
            this.DamageAbsorb = damageAbsorb;
        }

        public Armguard()
        {

        }

        public int Health { get; set; }

        public int DamageAbsorb { get; set; }

        public override string ToString()
        {
            return $"{this.Name} | Health: {this.Health} | Damage Absorb: {this.DamageAbsorb}";
        }

        public int CompareTo(Armguard other)
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
