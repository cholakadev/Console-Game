namespace Game.In_GameShop
{
    public class ShopItem
    {
        interface IShopItem
        {
            string Name { get; set; }
            double Price { get; set; }
        }
        public ShopItem()
        {

        }
        public ShopItem(string name, double price)
        {
            this.Name = name;
            this.Price = price;

        }

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
