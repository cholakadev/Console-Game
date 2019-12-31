namespace Game.InGameShop.Pets
{
    using In_GameShop;
    using System;

    public class Pet : ShopItem
    {
        public Pet()
        {
        }
        public Pet(string name, double price, int health, int damage, int damageAbsorb)
            : base(name, price)
        {
            this.Health = health;
            this.Damage = damage;
            this.DamageAbsorb = damageAbsorb;
        }

        public int Health { get; set; }
        public int Damage { get; set; }
        public int DamageAbsorb { get; set; }

        public override string ToString()
        {
            return $"{this.Name}{Environment.NewLine}" +
                $"Health: {this.Health}{Environment.NewLine}" +
                $"Damage: {this.Damage}{Environment.NewLine}" +
                $"Damage Absorb: {this.DamageAbsorb}{Environment.NewLine}" +
                $"Price: {this.Price}{Environment.NewLine}";
        }
    }
}
