namespace Game.Items
{
    public abstract class Gear
    {
        private string name;

        protected Gear(string name)
        {
            Name = name;
        }

        public Gear()
        {

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
