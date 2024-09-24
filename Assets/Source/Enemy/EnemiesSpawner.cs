using Cysharp.Threading.Tasks;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private DefaultEnemy _defaultEnemyPrefab;
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
        while (Application.isPlaying)
        {
            var enemy = _creator.CreateEnemy(_defaultEnemyPrefab);
            enemy.transform.position = new Vector2(Random.Range(-5f, 5f), 3f);
            await UniTask.Delay(1000);
        }
    }
}