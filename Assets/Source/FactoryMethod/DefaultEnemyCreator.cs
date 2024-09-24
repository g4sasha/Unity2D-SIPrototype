using UnityEngine;

public class DefaultEnemyCreator : IEnemyCreator
{
    public Enemy CreateEnemy(Enemy prefab) => Object.Instantiate(prefab);
}