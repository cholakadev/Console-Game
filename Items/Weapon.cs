namespace Game.Items
{
    using System;
    using System.Text;

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
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine($"Damage: {this.Damage}");

            return sb.ToString().TrimEnd();
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