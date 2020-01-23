namespace Game.Items.Weapons
{
    using System;
    public class Weapon : Item, IComparable<Weapon>
    {
        private int damage;
        public Weapon(string name, int damage) : base(name)
        {
            this.Damage = damage;
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
            return $"{this.Name}, Damage: {this.Damage}";
        }
    }
}
