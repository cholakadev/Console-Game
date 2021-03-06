﻿namespace Game.InGameShop.Pets
{
    using In_GameShop;
    using System.Text;

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

        public int Health { get; private set; }
        public int Damage { get; private set; }
        public int DamageAbsorb { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name}");
            sb.AppendLine($"Health: {this.Health}");
            sb.AppendLine($"Damage: {this.Damage}");
            sb.AppendLine($"Damage Absorb: {this.DamageAbsorb}");
            sb.AppendLine($"Price: {this.Price}");

            return sb.ToString();
        }
    }
}
