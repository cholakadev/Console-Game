namespace Game
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class Weapon : IEnumerable<Weapon>
    {
        public Weapon()
        {
            this.Weapons = new List<Weapon>();
        }
        public Weapon(string name, int damage)
        {
            this.Name = name;
            this.Damage = damage;
        }
        public List<Weapon> Weapons { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }

        public void AddWeapons()
        {
            Weapon weapon = new Weapon();
            GearManager.AddWeapons(weapon);

            //foreach (var wpn in weapon.Weapons)
            //{
            //    Console.WriteLine($"{wpn.Name} - {wpn.Damage}");
            //}
        }

        public IEnumerator<Weapon> GetEnumerator()
        {
            foreach (var weapon in Weapons)
            {
                yield return weapon;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
