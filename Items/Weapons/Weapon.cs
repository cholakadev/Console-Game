namespace Game.Items.Weapons
{
    using System;
    public class Weapon : Item
    {
        public Weapon(string name, int damage) : base(name)
        {
            this.Damage = damage;
        }

        public int Damage { get; set; }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}" +
                $"Damage: {this.Damage}{Environment.NewLine}";
        }
    }
}
