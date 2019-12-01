namespace Game
{
    public class GearManager
    {
        public static void AddWeapons(Weapon wpn)
        {
            Weapon weap = new Weapon();

            Weapon wpn1 = new Weapon("Bronze sword", UtilityMethods.Random(3, 7));
            Weapon wpn2 = new Weapon("Silver sword", UtilityMethods.Random(5, 9));
            Weapon wpn3 = new Weapon("Golden sword", UtilityMethods.Random(7, 11));
            Weapon wpn4 = new Weapon("Premium sword", UtilityMethods.Random(8, 13));

            wpn.Weapons.Add(wpn1);
            wpn.Weapons.Add(wpn2);
            wpn.Weapons.Add(wpn3);
            wpn.Weapons.Add(wpn4);
        }
    }
}
