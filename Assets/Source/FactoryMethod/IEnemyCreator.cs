namespace Source.FactoryMethod
{
    public interface IEnemyCreator
    {
        public Enemy.Enemy CreateEnemy(Enemy.Enemy prefab);
    }
}