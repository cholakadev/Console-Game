namespace Game.Characters.Monsters
{
    public abstract class EnemyCharacter : IEnemy
    {
        public EnemyCharacter(string name, int damage, int health)
        {
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
        }

        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public abstract void DefaultValues();
    }
}