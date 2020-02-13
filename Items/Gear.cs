namespace Game.Items
{
    public abstract class Gear
    {
        protected Gear(string name)
        {
            this.Name = name;
        }

        public Gear()
        {

        }

        public string Name { get; private set; }
    }
}