namespace Game.Items.Gears
{
    using System;
    public class Gear : Item, IComparable<Gear>
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

        public int CompareTo(Gear other)
        {
            if (this.DamageAbsorb > other.DamageAbsorb)
            {
                return 1;
            }

            else if (this.DamageAbsorb < other.DamageAbsorb)
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
            return $"{this.Name}, Health: {this.Health}, Damage Absorb: {this.DamageAbsorb}";
        }
    }
}
