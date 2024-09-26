using UnityEngine;

namespace Source.FactoryMethod
{
    public class DefaultEnemyCreator : IEnemyCreator
    {
        public Enemy.Enemy CreateEnemy(Enemy.Enemy prefab) => Object.Instantiate(prefab);
    }
}