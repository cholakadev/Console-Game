namespace Game.Characters
{
    using Game.Characters.Monsters;
    using Game.Methods;
    public class Battle
    {
        public void FightEngine(Player player, EnemyCharacter monster)
        {
            player.Health -= monster.Damage - player.DamageAbsorb;

            monster.Health -= player.Damage;
        }
    }
}
