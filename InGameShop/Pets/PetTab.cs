namespace Game.In_GameShop
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using InGameShop.Pets;

    public class PetTab : IEnumerable<ShopItem>
    {
        private List<ShopItem> petShop;

        public PetTab()
        {
            this.petShop = new List<ShopItem>();
        }

        public void AddShopItem(ShopItem item)
        {
            petShop.Add(item);
        }

        public void AddPet(PetTab inGameShopPetTab)
        {
            inGameShopPetTab.AddShopItem(new Pet("Rabbit", 0.75, 10, 2, 1));
            inGameShopPetTab.AddShopItem(new Pet("White Fox", 1.25, 15, 3, 1));
            inGameShopPetTab.AddShopItem(new Pet("Moon Rabbit", 2, 15, 3, 2));
            inGameShopPetTab.AddShopItem(new Pet("Little Vampire", 4.75, 10, 5, 2));
        }

        public void PrintPetTab(PetTab collection)
        {
            foreach (var pet in collection)
            {
                Console.WriteLine(pet);
            }
        }

        public IEnumerator<ShopItem> GetEnumerator()
        {
            foreach (var item in petShop)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
