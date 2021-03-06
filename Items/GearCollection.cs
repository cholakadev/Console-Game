﻿namespace Game.Items
{
    using System.Collections;
    using System.Collections.Generic;
    public class GearCollection : IEnumerable<Gear>
    {
        public GearCollection()
        {
            this.Gears = new List<Gear>();
        }

        public List<Gear> Gears { get; set; }

        public void AddGears()
        {
            this.Gears.Add(new Armor("Golden Cuirass", 10, 4));
            this.Gears.Add(new Armor("Silver Cuirass", 8, 3));
            this.Gears.Add(new Armor("Bronze Cuirass", 5, 1));

            this.Gears.Add(new Boots("Golden Boots", 10, 4));
            this.Gears.Add(new Boots("Silver Boots", 8, 3));
            this.Gears.Add(new Boots("Bronze Boots", 5, 1));

            this.Gears.Add(new Armguard("Golden Armguard", 10, 4));
            this.Gears.Add(new Armguard("Silver Armguard", 8, 3));
            this.Gears.Add(new Armguard("Bronze Armguard", 5, 1));

            this.Gears.Add(new Weapon("Golden Sword", 10));
            this.Gears.Add(new Weapon("Silver Sword", 8));
            this.Gears.Add(new Weapon("Bronze Sword", 5));
        }

        public IEnumerator<Gear> GetEnumerator()
        {
            foreach (var gear in Gears)
            {
                yield return gear;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}