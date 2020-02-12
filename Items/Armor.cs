namespace Game.Items
{
    using System;
    using System.Text;
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
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine($"Health: {this.Health}");
            sb.AppendLine($"Damage Absorb: {this.DamageAbsorb}");

            return sb.ToString().TrimEnd();
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
