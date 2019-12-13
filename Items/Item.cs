namespace Game
{
    public class Item
    {
        public Item(string name, int parameter)
        {
            this.Name = name;
            this.Parameter = parameter;
        }

        public string Name { get; set; }
        public int Parameter { get; set; }
    }
}
