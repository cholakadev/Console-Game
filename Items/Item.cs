namespace Game
{
    public class Item
    {
        interface IItem
        {
            string Name { get; set; }
        }
        public Item(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
