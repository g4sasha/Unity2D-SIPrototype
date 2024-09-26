using Cysharp.Threading.Tasks;
using UnityEngine;
using Source.FactoryMethod;

namespace Source.Enemy
{
    public class EnemiesSpawner : MonoBehaviour
    {
        [SerializeField] private EnemySpawnerConfig _config;
        private IEnemyCreator _creator;

        private void Awake()
        {
            _creator = new DefaultEnemyCreator();
        }

        private void Start()
        {
            SpawnCycle().Forget();
        }

        private async UniTaskVoid SpawnCycle()
        {
            for (int i = 0; i < _config.WavesCount; i++)
            {
                for (int j = 0; j < _config.SpawnCount; j++)
                {
                    var enemy = _creator.CreateEnemy(_config.Prefab);
                    var position = new Vector2(_config.SpawnDistanceInterval * j, 3f);
                    position -= new Vector2(_config.SpawnDistanceInterval * _config.SpawnCount / 2f - _config.SpawnDistanceInterval / 2, 0f);
                    enemy.transform.position = position;
                }

                await UniTask.Delay(_config.SpawnIntervalMs);
            }
        }
    }
}