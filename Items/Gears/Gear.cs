namespace Game.Items.Gears
{
    using System;
    public class Gear : Item
    {
        private int damageAbsorb;
        private int health;
        public Gear(string name, int health, int damageAbsorb) : base(name)
        {
            this.Health = health;
            this.DamageAbsorb = damageAbsorb;
        }

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
                    throw new ArgumentException("Gear Additional Health", "Health can't be less than 0.");
                }

                this.health = value;
            }
        }
        public int DamageAbsorb
        {
            get
            {
                return this.damageAbsorb;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Gear Additional Damage Absorb"
                        , "Damage Absorb can't be less than or equals to 0.");
                }

                this.damageAbsorb = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}" +
                $"Health: {this.Health}{Environment.NewLine}" +
                $"Damage Absorb: {this.DamageAbsorb}{Environment.NewLine}";
        }
    }
}
