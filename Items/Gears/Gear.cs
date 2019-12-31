namespace Game.Items.Gears
{
    using System;
    public class Gear : Item
    {
        public Gear(string name, int health, int damageAbsorb) : base(name)
        {
            this.Health = health;
            this.DamageAbsorb = damageAbsorb;
        }

        public int Health { get; set; }
        public int DamageAbsorb { get; set; }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}" +
                $"Health: {this.Health}{Environment.NewLine}" +
                $"Damage Absorb: {this.DamageAbsorb}{Environment.NewLine}";
        }
    }
}
